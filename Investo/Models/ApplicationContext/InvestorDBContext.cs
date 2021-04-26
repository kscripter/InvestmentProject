using System;
using System.Collections.Generic;
using Investo.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Investo.Models.ApplicationContext
{
    public class InvestorDBContext : IdentityDbContext
    {
        public InvestorDBContext(DbContextOptions options) : base(options)
        {

        }



        public DbSet<Investor> Investors { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Investment> Investments { get; set; }

        public DbSet<BankDetail> BankDetails { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Admin> Admins { get; set; }









        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Adding Constraints To The Investor Table

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Investor>().Property(Invest => Invest.FirstName)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<IdentityUser>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            modelBuilder.Entity<IdentityUser>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(85));
            modelBuilder.Entity<IdentityUser>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(85));

            modelBuilder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            modelBuilder.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(85));

            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(85));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));

            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));

            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(85));

            modelBuilder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));





            modelBuilder.Entity<Investor>().Property(Invest => Invest.FirstName)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Investor>().Property(Invest => Invest.LastName)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Investor>().Property(Invest => Invest.MiddleName)
                 .IsRequired();
            modelBuilder.Entity<Investor>().Property(Invest => Invest.Email)
               .IsRequired()
               .HasMaxLength(255);
            modelBuilder.Entity<Investor>().Property(Invest => Invest.Password)
               .IsRequired()
               .HasMaxLength(255);
            modelBuilder.Entity<Investor>().Property(Invest => Invest.DateOfBirth)
               .IsRequired();
            modelBuilder.Entity<Investor>().Property(Invest => Invest.PhoneNumber)
               .IsRequired()
               .HasMaxLength(11);
            modelBuilder.Entity<Investor>().Property(Invest => Invest.Address)
               .IsRequired()
               .HasMaxLength(255);



            // Declaring The  Relationship Between The Tables


            //    modelBuilder.Entity<Investor>()
            //  .HasOne(invest => invest.Account)
            //  .WithOne(acc => acc.Investor);

            //    modelBuilder.Entity<Investor>()
            //.HasOne(invest => invest.Investment);
            // .WithOne(investmt => investmt.Investor);


            //modelBuilder.Entity<Investor>()
            //    .HasOne(invest => invest.BankDetail)
            //    .WithOne(bdetails => bdetails.Investor);





            //Configure Primary Key For Account

            //modelBuilder.Entity<Account>()
            //    .HasKey(invest => invest.InvestorId);



        }


    }
}
