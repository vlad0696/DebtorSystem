using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DebtorsSystem.Models;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;

namespace DebtorsSystem.Controllers
{
    public class DebtorController : Controller
    {
        DebtorContext debtorContext;
        private  TelegramBotClient client;
        private readonly IHostingEnvironment _hostingEnvironment;

        public DebtorController(DebtorContext debtorContext, IHostingEnvironment hostingEnvironment)
        {
            this.debtorContext = debtorContext;
            _hostingEnvironment = hostingEnvironment;
        }

    
    public IActionResult Index()
        {
            List<Debtor> debtors = debtorContext.Debtors.ToList();
            List<DebtorTable> debtorTables = new List<DebtorTable>();
            foreach (Debtor debtor in debtors)
            {
                int year =  debtor.DateIssue.Year;
                if (debtorTables.Find(d => d.Year == year)!=null)
                {
                    debtorTables.Find(d => d.Year == year).AllRefund = (float.Parse(debtorTables.Find(d => d.Year == year).AllRefund) + float.Parse(debtor.RefundAmount)).ToString();
                    debtorTables.Find(d => d.Year == year).AllRefundResidue = (float.Parse(debtorTables.Find(d => d.Year == year).AllRefundResidue) + float.Parse(debtor.RefundResidue)).ToString();
                    debtorTables.Find(d => d.Year == year).debtors.Add(debtor);
                }
                else
                {
                    DebtorTable debtorTable = new DebtorTable();
                    debtorTable.Year = year;
                    debtorTable.debtors= new List<Debtor>();
                    debtorTable.debtors.Add(debtor);
                    debtorTable.AllRefund =debtor.RefundAmount;
                    debtorTable.AllRefundResidue =  debtor.RefundResidue;
                    debtorTables.Add(debtorTable);
                }
            }
            return View(debtorTables.OrderBy(d=>d.Year));
        }


        public IActionResult Archive()
        {
            List<Debtor> debtors = debtorContext.Debtors.ToList();
            List<DebtorTable> debtorTables = new List<DebtorTable>();
            foreach (Debtor debtor in debtors)
            {
                int year = debtor.DateIssue.Year;
                if (debtorTables.Find(d => d.Year == year) != null)
                {
                    debtorTables.Find(d => d.Year == year).AllRefund = (float.Parse(debtorTables.Find(d => d.Year == year).AllRefund) + float.Parse(debtor.RefundAmount)).ToString();
                    debtorTables.Find(d => d.Year == year).AllRefundResidue = (float.Parse(debtorTables.Find(d => d.Year == year).AllRefundResidue) + float.Parse(debtor.RefundResidue)).ToString();
                    debtorTables.Find(d => d.Year == year).debtors.Add(debtor);
                }
                else
                {
                    DebtorTable debtorTable = new DebtorTable();
                    debtorTable.Year = year;
                    debtorTable.debtors = new List<Debtor>();
                    debtorTable.debtors.Add(debtor);
                    debtorTable.AllRefund = debtor.RefundAmount;
                    debtorTable.AllRefundResidue = debtor.RefundResidue;
                    debtorTables.Add(debtorTable);
                }
            }
            return View(debtorTables.OrderBy(d => d.Year));
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {

            Debtor debtor = debtorContext.Debtors.SingleOrDefault(d=>d.Id==Id);
            return View(debtor.ConvertToDebtorModel());
         
        }
        [HttpGet]
        public IActionResult Notification(int Id)
        {

            Debtor debtor = debtorContext.Debtors.SingleOrDefault(d => d.Id == Id);
            debtor.NotificationViewRefund = true;
            debtorContext.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public IActionResult Edit([FromBody]DebtorModel debtorForm)
        {

            if (debtorForm != null)
            {
                Debtor debtor = debtorContext.Debtors.SingleOrDefault(x=>x.Id==int.Parse(debtorForm.Id));
                debtorForm.ConvertToDepter(ref debtor);
                debtorContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SendSMS()
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect("127.0.0.1", 8888);
            NetworkStream stream = tcpClient.GetStream();
            string response = "Hello world!";
            byte[] data = System.Text.Encoding.UTF8.GetBytes(response);
            stream.Write(data, 0, data.Length);
            stream.Close();
            tcpClient.Close();
            //var client = new TelegramBotClient("700794760:AAFaQrnpKpMIEU3VaQQ__DL9BYXYmS9dDos");
            //client.SendTextMessageAsync("241175466", "hi");
            return Ok();
        }


        [HttpPost]
        public IActionResult Add([FromBody]DebtorModel debtorForm)
        {
            Debtor debtor;

            if (debtorForm != null)
            {
                debtor = debtorForm.ConvertToDepter();
                debtorContext.Debtors.Add(debtor);
                debtorContext.SaveChanges();
            }

           return View();

        }

        class Item
        {
           public string name;
           public string html_url;
        }
        public JsonResult Search(string q)
        {
            var debtors = from d in debtorContext.Debtors
                          where d.FIO.ToLower().StartsWith(q.ToLower())
                          select d;
            List<Item> items = new List<Item>();
            
            foreach (var d in debtors)
            {
                items.Add(new Item()
                {
                    name = d.FIO,
                    html_url = "//localhost:44357/Debtor/Edit?id=" + d.Id.ToString()
                });
            }
            return new JsonResult(new { Items=items });
        }

        public IActionResult Admin()
        {
            return View();
        }

        public void SaveDB()
        {
            var binFormatter = new BinaryFormatter();
            using (StreamWriter file = System.IO.File.CreateText(@"C:\path.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, debtorContext.Debtors.ToList());
            }
        }
        [HttpPost]
        public void DownloadBD([FromBody]string Mails )
        {
           
            //serializer.Deserialize<List<Debtor>>(new JsonReader());
           var jsonData = JsonConvert.DeserializeObject<List<Debtor>>(Mails);
            foreach(Debtor debtor in jsonData)
            {
                debtor.Id = 0;
                debtorContext.Debtors.Add(debtor);
            }
            debtorContext.SaveChanges();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
