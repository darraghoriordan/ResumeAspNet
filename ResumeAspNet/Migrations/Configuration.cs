using System.Collections.Generic;
using Fuzzyminds.ResumeAspNet.Models;
using Fuzzyminds.ResumeAspNet.ResumeDto;

namespace Fuzzyminds.ResumeAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Fuzzyminds.ResumeAspNet.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.ApplicationDbContext context)
        {
            const string myEmail = "darragh.oriordan@gmail.com";
            ResumeRecord resume = context.ResumeRecords.FirstOrDefault(r => r.Email == myEmail);

            if (resume == null)
            {
                resume = new ResumeRecord();
            }
            
            resume.Email = "darragh.oriordan@gmail.com";
            resume.Name = "Darragh O'Riordan";
            resume.LastModifiedTimestamp = DateTime.UtcNow;

            context.PhoneNumberRecords.Clear();
            resume.PhoneNumber = new PhoneNumberRecord()
            {
                Number = 1234567,
                Type = PhoneNumberType.Mobile
            };

            context.PositionRecords.Clear();
            context.CompanyRecords.Clear();
            var tradeMeCompany = new CompanyRecord()
            {
                Address = "66 Sale St",
                City = "Auckland",
                Country = "New Zealand",
                Name = "Trade Me Ltd"
            };
          
            resume.PositionRecords = new List<PositionRecord>
            {
                new PositionRecord()
                {
                    Title = "Development Chapter Lead",
                    Summary = "Chapter leading things",
                    Company = tradeMeCompany,
                    IsCurrent = true,
                    StartDate = new DateTime(2014, 10, 12, 1, 1, 1, DateTimeKind.Utc)
                }
            };
           
            context.ResumeRecords.Add(resume);
            context.SaveChanges();
        }
    }
}
