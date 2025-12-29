using System.Collections.Generic;

namespace StudentEnrollment
{
    public class DegreeModel
    {
        public string Name { get; set; } = string.Empty;
        public int FilledSeats { get; set; }
        public int TotalSeats { get; set; }
        public IList<CourseModel> Courses { get; set; } = new List<CourseModel>();
        public IList<GenderStat> Gender { get; set; } = new List<GenderStat>();
        public IList<CountryStat> Countries { get; set; } = new List<CountryStat>();
    }
}