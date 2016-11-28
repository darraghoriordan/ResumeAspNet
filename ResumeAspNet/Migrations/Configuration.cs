using System.Collections.Generic;
using System.Data.Entity;
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
        /// <summary>
        /// OK so this is a pretty cray cray way to populate this data, json or even XML 
        /// would make more sense for a little application but I'm just showing some 
        /// seeding of data and it lets me output the data any way i like later using the object model.
        /// </summary>
        /// <param name="context">We need the context to do the seeding</param>
        protected override void Seed(Models.ApplicationDbContext context)
        {
            const string myEmail = "darragh.oriordan@gmail.com";
            ResumeRecord resume = context.ResumeRecords.FirstOrDefault(r => r.Email == myEmail);

            if (resume == null)
            {
                resume = new ResumeRecord();
            }
            resume.Interests = new List<InterestRecord>()
            {
                new InterestRecord("Travel"),
                new InterestRecord("Sailing"),
                new InterestRecord("Stand up paddle boarding"),
                new InterestRecord("Bicycling"),
                new InterestRecord("Camping"),
                new InterestRecord("Hiking"),
                new InterestRecord("Technology"),
                new InterestRecord("Playing Guitar"),
                new InterestRecord("Motorcycles"),
                new InterestRecord("Chocolate"),
                new InterestRecord("Beer")
            };
            resume.Email = "darragh.oriordan@gmail.com";
            resume.Name = "Darragh O'Riordan";
            resume.LastModifiedTimestamp = DateTime.UtcNow;
            resume.Summary =
                @"I am a senior software developer and systems integrator with experience in the telecommunications, pharmaceutical and consumer media industries. Using .Net, C# and MS SQL I create intuitive web and windows applications, libraries and tools for gathering and reporting business data. I have excellent interpersonal, organizational and customer relationship skills through my experience in various working environments in Ireland, the USA, Canada and New Zealand.

Skills

C# and VB.Net
Server-side web - ASP.NET webforms and MVC, some Node.js - mainly for Yeoman
Web services – WCF, SOAP and RESTful, WebApi2
Client-side web - HTML, XML, AJAX, JQuery, CSS, JavaScript, Angular, Bootstrap and gulp for keeping all together
Databases - Microsoft SQL Server and Oracle/PLSQL, Entity Framework, NHibernate and Dapper ORMs
Client Native - Windows Forms and services
Software change management - Perforce / SVN, Git, mercurial, Hudson
Hardware interfacing and integration - National Instruments mostly

I have a huge interest in science, computing and technology in general. I am genuinely amazed at how computing has exploded in to our lives and I'm delighted to be a part of it.";
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
                City = "Auckland Central",
                State = "Auckland",
                Country = "New Zealand",
                Name = "Trade Me Ltd"
            };
            var travellingCompany = new CompanyRecord()
            {
                Address = "Africa",
                City = "Europe",
                State = "Auckland",
                Country = "North America",
                Name = "Travelling"
            };
            var blackberryCompany = new CompanyRecord()
            {
                Address = "Waterloo",
                City = "Waterloo",
                State = "Ontario",
                Country = "Canada",
                Name = "Blackberry Ltd"
            };

            var zenithCompany = new CompanyRecord()
            {
                Address = "Ringaskiddy",
                City = "Ringaskiddy",
                State = "Co Cork",
                Country = "Ireland",
                Name = "Zenith Technology Ltd"
            };
            var bauerMediaCompany = new CompanyRecord()
            {
                Address = "City Works Depot",
                City = "Auckland Central",
                State = "Auckland",
                Country = "New Zealand",
                Name = "Bauer Media"
            };
            resume.PositionRecords = new List<PositionRecord>
            {
                new PositionRecord()
                {
                    Title = "Development Chapter Lead",
                    Summary = @"Helped business by providing technical expertise in areas such as...
? Performing techincal due diligence for acquisition
? Driving Summer of Tech intern engagement which resulted in attracting all of our top picks 
? Performing internal audits of APIs and other software to drive technical architecture strategy and improvement
? Performing technical interviews for roles in other locations and other departments
? Interviewing for additional technical lead and managing all 8 developers while recruiting, I manage 5 developers now that we have two leads
? Nominated for internal technical excellence award

Actively developing reports by...
? Peer programming and one on one teaching
? Providing introductory courses for new hires and interns
? Running a hackathon type event called Wrench Day for the motors organisation
? Driving reports to spread their knowledge through tutorials and laboratories
? Mentoring developers in other departments
? Ensuring reports are using OKRs, PDPs and skills matrices to guide their work and learning
? Encouraging and organising for reports to go to various conferences such as Codemania and Webstock

Improving our product by...
? Driving changes to move an internal windows forms application to a web based application
? Writing scripts to make deploy process automatic and repeatable(saving ~2 hours/deploy)
? Adding swagger to document our API
? Adding alpha channel for deploying internal applications to selected users for UAT
? Bringing our SQL schema into the code repository for auditing
? Creating code review guidelines
? Introducing unit testing,DI and actively updated solution with examples for devs to use
? Helping our platform team perform site moves, backups and hardware crash recovery
? Introducing miniprofiler to help developers uncover performance issues
? Rewriting logging to reduce logs by 20 million/day and support splunk for monitoring
? Driving a move to salesforce for our customer management and billing",
                    Company = tradeMeCompany,
                    IsCurrent = true,
                    StartDate = new DateTime(2015, 9, 1, 1, 1, 1, DateTimeKind.Utc)
                },
                new PositionRecord()
                {
                    Title = "Developer",
                    Summary = @"I was a product developer on the Motors vertical, adding new product, fixing bugs. Typical .Net stack with a few different front ends - angularJS, bootstrap, Asp.Net MVC and webforms, gulp, teamcity, some VB, lots of SQL.

? Scrum master for squad of 5
? Shipped Video in listings for direct sellers
? Shipped MotorWeb vehicle report integration product for direct customers
? Shipped Pit Board analytics product for dealers
? Shipped Pulse, an award winning FedEx day project providing data visualization of user interactions on Trade Me",
                    Company = tradeMeCompany,
                    StartDate = new DateTime(2014, 10, 11, 1, 1, 1, DateTimeKind.Utc),
                     EndDate = new DateTime(2015, 9, 1, 1, 1, 1, DateTimeKind.Utc)
                },
                new PositionRecord()
                {
                    Title = "Developer",
                    Summary = @"I was lead developer with one junior on autotrader.co.nz. It's a full Microsoft stack MVC site in C#.

? Lead developer for autotrader.co.nz
? Continuously added product features from the business while reducing tech debt and improving infrastructure
? Added phone proxy product to hide customer phone numbers from scammers
? Added new and improved existing advertising
? Full upgrade for mobile site to latest jquery mobile
? Added support for https across the entire site
? Added support for white labelling the site to support new partners and advertisers
? Moved all static content to CDN
? Implemented move to Amazon Web Services cloud infrastructure
? Automated the release process with Jenkins and moved build process to MSBuild
? Started first automated tests for product with NUnit and Selenium
? Got database schemas versioned in to source control
? Played active role in implementing scrum, moving towards continuous delivery and reducing sprint length
? Mentored junior developers and new team members",
                    Company = bauerMediaCompany,
                    StartDate = new DateTime(2013, 10, 11, 1, 1, 1, DateTimeKind.Utc),
                     EndDate = new DateTime(2014, 10, 11, 1, 1, 1, DateTimeKind.Utc)
                },
                      new PositionRecord()
                {
                    Title = "Career Break",
                    Summary = @"? I flew to Egypt and rode my bicycle from Cairo to Cape Town as part of the 2013 Tour d'Afrique race. 
? I rested the bum and decompressed in South Africa, travelling along the the garden route and southern coast to Durban and the Drakensbergs. I sailed a delivery yacht from Durban back to Cape Town.
? I returned to Europe for a month to see some music, old friends and new sights.
? Finally I flew to North America and fulfilled a long time wish of driving my motorcycle from Toronto to the Arctic circle in the Northwest Territories and 
? 12, 000km of Canadian wilderness later I finished in Vancouver for a flight to Auckland and a life without winter!",
                    Company = travellingCompany,
                    StartDate = new DateTime(2012, 12, 12, 1, 1, 1, DateTimeKind.Utc),
                     EndDate = new DateTime(2013, 10, 12, 1, 1, 1, DateTimeKind.Utc)
                },
                new PositionRecord()
                {
                    Title = "Developer / System integrator",
                    Summary = @"?      Designed, developed and managed  system to securely track thousands of hardware samples, providing full oversight of global hardware testing activities.
?	Integrated many external systems including Active Directory, Security badges, an automated sample transfer/mailing system and legacy Oracle databases.
?	Supported huge growth in RIM’s hardware portfolio and provided enormous benefit to the managers and staff including centralized process control, audit trails and real time reporting.
?	Designed APIs and tooling that allowed rapid integration of sample tracking and test data collection to test software.
?	Improved throughput on RIMs new product programs by designing a service oriented, multilayer, secure, automated mailing system for transporting sensitive devices around the RIM campus.
?	Provided additional support for test software, which included upgrading test systems’ connection stacks to support a completely new mobile OS and refactoring code to reduce future maintenance.

Additional Activities

?	Adhered to RIMs strict project execution methodology and documentation procedure.
?	5s + 1 champion.
?	Member of the Health & Safety Committee(WSIB Certified).",
                    Company = blackberryCompany,
                    StartDate = new DateTime(2009, 3, 12, 1, 1, 1, DateTimeKind.Utc),
                     EndDate = new DateTime(2012, 12, 12, 1, 1, 1, DateTimeKind.Utc)
                },
                new PositionRecord()
                {
                    Title = "Developer Intern",
                    Summary = @"?	Designed, developed and managed a custom ASP.NET learning management system to improve efficiency in administration of the training department for 100 worldwide employees.
?	Administered Windows Server including IIS and Microsoft SQL Server.
?	Created work estimations and task prioritization for management and compiled weekly progress reports.Consistently showed ability to self - manage.
?	Fixed bugs in VB.NET soft phase code for a new Emerson Delta V automation system.
?	Demonstrated flexibility in working hours and commitment.
?	Tested DeltaV Hardware, Graphics, Interlocks, Equipment modules and phases.
?	Created high quality GAMP documentation to perform the above testing.
?	Participated in factory acceptance testing directly with clients.
?	Supported intensive project work over summer months.
?	Practiced safety procedures for industrial environments.",
                    Company = zenithCompany,
                    StartDate = new DateTime(2007, 4, 12, 1, 1, 1, DateTimeKind.Utc),
                     EndDate = new DateTime(2008, 9, 12, 1, 1, 1, DateTimeKind.Utc)
                },

            };

            resume.EducationRecords = new List<EducationRecord>();
            resume.EducationRecords.Add(new EducationRecord()
            {
                Degree = "Bachelor of Science (Honors) in Computerised Instrumentation",
                FieldOfStudy = "Applied Physics",
                EndDate = new DateTime(2008, 10, 12, 1, 1, 1, DateTimeKind.Utc),
                Notes = "Finished first in class in 1st and final year. Achieved H1.1 grade",
                SchoolName = "Cork Institute of Technology",
                StartDate = new DateTime(2004, 10, 12, 1, 1, 1, DateTimeKind.Utc)
            });
            resume.EducationRecords.Add(new EducationRecord()
            {
                Degree = "Certificate in Electronic Engineering",
                FieldOfStudy = "Electronic Engineering",
                EndDate = new DateTime(2004, 10, 12, 1, 1, 1, DateTimeKind.Utc),
                SchoolName = "Cork Institute of Technology",
                StartDate = new DateTime(2001, 10, 12, 1, 1, 1, DateTimeKind.Utc)
            });
            context.ResumeRecords.Add(resume);
            context.SaveChanges();
        }
    }
}
