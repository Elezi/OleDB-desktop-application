using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTest.ChapterOneProject;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var patient = new Patient();
            Patient.CreateNewPatient();
        }
    }
}
