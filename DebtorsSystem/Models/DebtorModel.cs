using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebtorsSystem.Models
{
    public class DebtorModel
    {
        public string Id { get; set; }
        public string FIO { get; set; }
        public string DateIssue { get; set; }
        public string TrainingLevel { get; set; }
        public string Address { get; set; }
        public string DateWorkStarted { get; set; }
        public string DateWorkStopped { get; set; }
        public string RefundAmount { get; set; }
        public string DateRefund { get; set; }
        public string RefundBeforeTrial { get; set; }
        public string DateTrial { get; set; }
        public string RefundAfterTrial { get; set; }
        public string ExecutionStopped { get; set; }
        public string DateExecution { get; set; }
        public string DateResumptionExecution { get; set; }
        public string RefundResidue { get; set; }
        public string Reimbursed { get; set; }
        public string Mails { get; set; }

        public Debtor ConvertToDepter(ref Debtor debtor)
        {
            debtor.Id = int.Parse(Id);
            debtor.FIO = FIO;
            debtor.DateIssue = DateIssue != "" ? convertToDate(DateIssue) : new DateTime(1, 1, 1);

            if (TrainingLevel == "1")
            {
                debtor.TrainingLevel = "ПТО";
            }
            else
            {
                debtor.TrainingLevel = "ССО";
            }
            debtor.Address = Address;
            debtor.DateWorkStarted = DateWorkStarted != "" ? convertToDate(DateWorkStarted) : new DateTime(1, 1, 1);
            debtor.DateWorkStopped = DateWorkStopped != "" ? convertToDate(DateWorkStopped) : new DateTime(1, 1, 1);
            debtor.RefundAmount = RefundAmount;
            debtor.DateRefund = DateRefund != "" ? convertToDate(DateRefund) : new DateTime(1, 1, 1);
            debtor.RefundBeforeTrial = RefundBeforeTrial;
            debtor.DateTrial = DateTrial != "" ? convertToDate(DateTrial) : new DateTime(1, 1, 1);
            debtor.RefundAfterTrial = RefundAfterTrial;
            debtor.DateExecution = DateExecution != "" ? convertToDate(DateExecution) : new DateTime(1, 1, 1);
            debtor.DateResumptionExecution = DateResumptionExecution != "" ? convertToDate(DateResumptionExecution) : new DateTime(1, 1, 1);
            debtor.Mails = Mails;
            return debtor;
        }

        public Debtor ConvertToDepter()
        {
            Debtor debtor = new Debtor();
            debtor.FIO = FIO;
            debtor.DateIssue = DateIssue != "" ? convertToDate(DateIssue) : new DateTime(1, 1, 1);
            if (TrainingLevel == "1")
            {
                debtor.TrainingLevel = "ПТО";
            }
            else
            {
                debtor.TrainingLevel = "ССО";
            }
            debtor.Address = Address;
            debtor.DateWorkStarted = DateWorkStarted != "" ? convertToDate(DateWorkStarted) : new DateTime(1, 1, 1);
            debtor.DateWorkStopped = DateWorkStopped != "" ? convertToDate(DateWorkStopped) : new DateTime(1, 1, 1);
            debtor.RefundAmount = RefundAmount;
            debtor.DateRefund = DateRefund != "" ? convertToDate(DateRefund) : new DateTime(1, 1, 1);
            debtor.RefundBeforeTrial = RefundBeforeTrial;
            debtor.DateTrial = DateTrial != "" ? convertToDate(DateTrial) : new DateTime(1, 1, 1);
            debtor.RefundAfterTrial = RefundAfterTrial;
            debtor.DateExecution = DateExecution != "" ? convertToDate(DateExecution) : new DateTime(1, 1, 1);
            debtor.DateResumptionExecution = DateResumptionExecution != "" ? convertToDate(DateResumptionExecution) : new DateTime(1, 1, 1);
            debtor.Mails = Mails;
            return debtor;
        }
        //Февраль 20, 2019
        private DateTime convertToDate(string value)
        {

            //string[] values = value.Split(' ');
            //values[1] = values[1].Remove(values[1].Length-1, 1);
            //string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            //int month = 0;
            //for(int i = 0; i < 12; i++)
            //{
            //    if (months[i] == values[0])
            //    {
            //        month = i + 1;
            //    }
            //}
            //DateTime dateTime = new DateTime(int.Parse(values[2]), month, int.Parse(values[1]));

            string[] values = value.Split('.');
            DateTime dateTime = new DateTime(int.Parse(values[2]), int.Parse(values[1]), int.Parse(values[0]));
            return dateTime;
        }
    }

}
