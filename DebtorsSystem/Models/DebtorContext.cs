using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebtorsSystem.Models
{
    public class DebtorContext:DbContext
    {
        public DbSet<Debtor> Debtors { get; set; }

        public DebtorContext(DbContextOptions<DebtorContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
