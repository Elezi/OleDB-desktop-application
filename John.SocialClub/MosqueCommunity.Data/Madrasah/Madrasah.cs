using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.Data.Madrasah
{
    class MadrasahInfo
    {
        Mosque Mosque;
        PersonalInformation Principal;

    }
    class Madrasah
    {
        MadrasahInfo info;
        List<Field> fields;
        List<Teacher> facultyMembers;
        List<Premise> premises;
    }
}
