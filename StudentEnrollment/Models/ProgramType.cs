namespace StudentEnrollment
{
    public class ProgramType
    {
        public string Course { get; set; }
        public int StudentCountByCourse { get; set; }

        public ProgramType(string course,int studentCountByCourse)
        {
            Course = course;
            StudentCountByCourse = studentCountByCourse;
        }
    }

}
