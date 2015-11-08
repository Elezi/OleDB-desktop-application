using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.Data.Madrasah
{
    class Student
    {
        Guid StudentID;
        PersonalInformation StudentInfo;
        List<Parent> Parents;
        List<Lesson> Lessons;
       // Dictionary<LessonClass, bool> Attendance;
        Dictionary<Lesson, Grade> Grades;
        Timetable timetable;
    }
}
