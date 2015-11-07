using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.Data.Madrasah
{
    public class CalendarUnits
    {

    }
    public  class TimeUnitSemester
    {
        public DateTime SemesterBegin;
        public DateTime SemesterEnd;
        List<SemesterWeek> Weeks;
    }
    public class SemesterWeek
    {
        const int DaysInWeek = 7;
        const int WorkingDays = 5;
        TimeUnitSemester Semester;
        int WeekNumber;
        DateTime WeekBegin { get { return Semester.SemesterBegin.AddDays(WeekNumber * DaysInWeek); } }
        DateTime WeekEnd { get { return WeekBegin.AddDays(WorkingDays); } }
    }
    public class SemesterDay 
    {
        SemesterWeek Week;
        int DayNumber;
        DateTime Date;
        List<SemesterHour> SemesterHours;
    }
    public class SemesterHour
    {
        DateTime TimeBegin;
        DateTime TimeEnd;
    }

}
