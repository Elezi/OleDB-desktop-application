using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFTest.ChapterOneProject
{
   
        class VetContext : DbContext
        {
            public DbSet<Patient> Patients { get; set; }
            public DbSet<Visit> Visits { get; set; }
        }

    }
