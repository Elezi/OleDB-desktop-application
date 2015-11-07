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
        MadrasahInfo Info;
        List<Lesson>  Curriculum;
        List<Teacher> FacultyMembers;
        List<Premise> Premises;
    }
}
