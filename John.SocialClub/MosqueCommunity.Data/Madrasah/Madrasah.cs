using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.Data.Madrasah
{
    class MadrasahInfo
    {
        public Mosque Mosque { get; set; }
        public PersonalInformation Principal{ get; set; }

    }
    class Madrasah
    {
        MadrasahInfo info;
        List<Field> fields;
        List<Teacher> facultyMembers;
        List<Premise> premises;
    }
}
