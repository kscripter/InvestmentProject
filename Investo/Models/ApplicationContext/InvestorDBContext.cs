using System;
using System.Collections.Generic;
using Investo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investo.Models.ApplicationContext
{
    public class InvestorDBContext : DbContext
    {
        public InvestorDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Investor> Investors { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<TransactionHistory> TransactionHistorys { get; set; }


        public DbSet<InvestmentType> InvestmentTypes { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<BankDetails> BankDetails { get; set; }

        public DbSet<Manager> Managers { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Adding Constraints To The Investor Table
            modelBuilder.Entity<Investor>().Property(invest => invest.FirstName)
                .IsRequired()
                .HasMaxLength(255);


            modelBuilder.Entity<Investor>().Property(invest => invest.MiddleName)
                 .IsRequired();


            modelBuilder.Entity<Investor>().Property(invest => invest.LastName)
                .IsRequired()
                .HasMaxLength(255);


            modelBuilder.Entity<Investor>().Property(invest => invest.Email)
               .IsRequired()
               .HasMaxLength(255);


            modelBuilder.Entity<Investor>().Property(invest => invest.Password)
               .IsRequired()
               .HasMaxLength(255);


            modelBuilder.Entity<Investor>().Property(invest => invest.DateOfBirth)
               .IsRequired();


            modelBuilder.Entity<Investor>().Property(invest => invest.PhoneNumber)
               .IsRequired()
               .HasMaxLength(11);


            modelBuilder.Entity<Investor>().Property(invest => invest.Address)
               .IsRequired()
               .HasMaxLength(255);



            // Declaring The  Relationship Between The Tables

            modelBuilder.Entity<Investor>()
                .HasOne(invest => invest.Account)
                .WithOne(acc => acc.Investor);


            modelBuilder.Entity<Investor>()
                .HasMany(invest => invest.InvestmentTypes)
                .WithOne(investmentType => investmentType.Investor);



            //Configure Primary Key For Account

            modelBuilder.Entity<Account>()
                .HasKey(invest => invest.Investor);



        }
    }
}