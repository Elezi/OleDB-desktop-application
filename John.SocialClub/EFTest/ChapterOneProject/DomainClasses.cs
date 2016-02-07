using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace EFTest.ChapterOneProject
{
    class Patient
    {
        public Patient()
        {
            Visits = new List<Visit>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public AnimalType AnimalType { get; set; }
        public DateTime FirstVisit { get; set; }
        public List<Visit> Visits { get; set; }

        public static void CreateNewPatient()
        {
            var dog = new AnimalType { TypeName = "Dog" };
            var patient = new Patient
            {
                Name = "Sampson",
                BirthDate = new DateTime(2008, 1, 28),
                AnimalType = dog,
                Visits = new List<Visit>
                {
                    new Visit
                {
                    Date = new DateTime(2011, 9, 1)
                }
                }
        };
            using (var context = new VetContext())
            {
                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }

    }
    class Visit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public String ReasonForVisit { get; set; }
        public String Outcome { get; set; }
        public Decimal Weight { get; set; }
        public int PatientId { get; set; }
    }
    class AnimalType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
    }


}
