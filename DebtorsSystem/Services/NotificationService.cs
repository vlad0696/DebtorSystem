using DebtorsSystem.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace DebtorsSystem.Services
{
    public class NotificationService:IHostedService
    {

        private readonly IServiceScopeFactory scopeFactory;
        static object synclock = new object();
        private readonly ILogger _logger;
        private Timer _timer;
        private bool sendFlag=false;

        public NotificationService(IServiceScopeFactory scopeFactory )
        {
            this.scopeFactory = scopeFactory;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {

            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(60));

        }

        private void DoWork(object state)
        {
            lock (synclock)
            {
                try
                {
                    using (var scope = scopeFactory.CreateScope())
                    {
                        var dbContext = scope.ServiceProvider.GetRequiredService<DebtorContext>();
                        List<Debtor> debtors = dbContext.Debtors.ToList();
                        String fio = "";
                        foreach (Debtor debtor in debtors)
                        {
                            if ((debtor.DateRefund.AddMonths(6).Date <= DateTime.Now.Date) && (!debtor.NotificationRefund) && (float.Parse(debtor.RefundResidue) > 0))
                            {
                                if (debtor.DateNotificationRefund.Date == new DateTime(1, 1, 1).Date)
                                {
                                    fio = debtor.FIO + " " + fio;
                                    debtor.NotificationRefund = true;
                                    debtor.DateNotificationRefund = DateTime.Now;
                                }
                            }
                        }
                        if (fio != "")
                        {
                            TcpClient tcpClient = new TcpClient();
                            tcpClient.Connect("127.0.0.1", 8888);
                            NetworkStream stream = tcpClient.GetStream();
                            string response = fio + "- нужно подать в суд!";
                            byte[] data = System.Text.Encoding.UTF8.GetBytes(response);
                            sendFlag = true;
                            stream.Write(data, 0, data.Length);
                            stream.Close();
                            tcpClient.Close();
                        }
                        dbContext.SaveChanges();
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
