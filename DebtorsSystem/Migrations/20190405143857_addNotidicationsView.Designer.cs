﻿// <auto-generated />
using System;
using DebtorsSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DebtorsSystem.Migrations
{
    [DbContext(typeof(DebtorContext))]
    [Migration("20190405143857_addNotidicationsView")]
    partial class addNotidicationsView
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DebtorsSystem.Models.Debtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateExecution");

                    b.Property<DateTime>("DateIssue");

                    b.Property<DateTime>("DateRefund");

                    b.Property<DateTime>("DateResumptionExecution");

                    b.Property<DateTime>("DateTrial");

                    b.Property<DateTime>("DateWorkStarted");

                    b.Property<DateTime>("DateWorkStopped");

                    b.Property<string>("FIO");

                    b.Property<string>("Mails");

                    b.Property<bool>("NotificationExecution");

                    b.Property<bool>("NotificationRefund");

                    b.Property<bool>("NotificationTrial");

                    b.Property<bool>("NotificationViewExecution");

                    b.Property<bool>("NotificationViewRefund");

                    b.Property<bool>("NotificationViewTrial");

                    b.Property<string>("RefundAfterTrial");

                    b.Property<string>("RefundAmount");

                    b.Property<string>("RefundBeforeTrial");

                    b.Property<string>("TrainingLevel");

                    b.HasKey("Id");

                    b.ToTable("Debtors");
                });
#pragma warning restore 612, 618
        }
    }
}
