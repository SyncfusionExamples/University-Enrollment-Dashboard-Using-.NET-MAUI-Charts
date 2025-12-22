
namespace StudentEnrollment
{
    /// <summary>
    /// 
    /// </summary>
    public class CourseModel
    {
        public string Name { get; set; } = string.Empty;
        public int Students { get; set; }
        public List<ProgramType>? ProgramTypes { get; set; }
    }
}