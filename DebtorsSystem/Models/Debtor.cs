﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebtorsSystem.Models
{
    public class Debtor
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime DateIssue { get; set; }
        public string TrainingLevel { get; set; }
        public string Address { get; set; }
        public DateTime DateWorkStarted { get; set; }
        public DateTime DateWorkStopped { get; set; }
        public string RefundAmount { get; set; }
        public DateTime DateRefund { get; set; }
        public string RefundBeforeTrial { get; set; }
        public DateTime DateTrial { get; set; }
        public string RefundAfterTrial { get; set; }
        public DateTime DateExecution { get; set; }
        public DateTime DateResumptionExecution { get; set; }
        public string RefundResidue { get => ((RefundAmount!=""?float.Parse(RefundAmount):0) - (RefundBeforeTrial!=""?float.Parse(RefundBeforeTrial):0) 
                                            - (RefundAfterTrial!=""?float.Parse(RefundAfterTrial):0)).ToString(); }
        public bool Reimbursed { get { return float.Parse(RefundResidue) > 0 ? false : true; } }
        public string Mails { get; set; }

        public DebtorModel ConvertToDebtorModel()
        {
            DebtorModel debtorModel = new DebtorModel();
            debtorModel.Id = Id.ToString();
            debtorModel.FIO = FIO;
            debtorModel.DateIssue = ConvetFromDateTime(DateIssue);
            debtorModel.TrainingLevel = TrainingLevel;
            debtorModel.Address = Address;
            debtorModel.DateWorkStarted = ConvetFromDateTime(DateWorkStarted);
            debtorModel.DateWorkStopped = ConvetFromDateTime(DateWorkStopped);
            debtorModel.RefundAmount = RefundAmount;
            debtorModel.RefundAmount = RefundAmount;
            debtorModel.DateRefund = ConvetFromDateTime(DateRefund);
            debtorModel.RefundBeforeTrial = RefundBeforeTrial;
            debtorModel.DateTrial = ConvetFromDateTime(DateTrial);
            debtorModel.RefundAfterTrial = RefundAfterTrial;
            debtorModel.DateExecution = ConvetFromDateTime(DateExecution);
            debtorModel.DateResumptionExecution = ConvetFromDateTime(DateResumptionExecution);
            debtorModel.RefundResidue = RefundResidue;
            debtorModel.Mails = Mails;
            return debtorModel;
        }

        private string ConvetFromDateTime(DateTime dateTime)
        {
            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            string month="";
            for (int i = 0; i < 12; i++)
            {
                if (i+1 ==dateTime.Month)
                {
                    month = months[i];
                }
            }
            return $"{month} {dateTime.Day}, {dateTime.Year}";
        }
    }
}