using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;

namespace StudentEnrollment
{
    public partial class EnrollmentViewModel : INotifyPropertyChanged
    {
        #region Fields

        private DegreeModel? _selectedDegree;

        #endregion

        #region Properties
        public DegreeModel? SelectedDegree
        {
            get => _selectedDegree;
            set
            {
                if (_selectedDegree != value)
                {
                    _selectedDegree = value;
                    OnPropertyChanged();
                    // Notify dependent bindings
                    OnPropertyChanged(nameof(GaugeTotal));
                    OnPropertyChanged(nameof(AdmittedSeatsByDegree));
                    OnPropertyChanged(nameof(GenderStats));
                    OnPropertyChanged(nameof(CountryStats));
                    OnPropertyChanged(nameof(GaugeShapePointer));
                    OnPropertyChanged(nameof(RemainingVacancies));
                    OnPropertyChanged(nameof(ApplicationCloseText));
                }
            }
        }
        public ObservableCollection<DegreeModel> Degrees { get; }
        public int GaugeTotal => SelectedDegree?.FilledSeats ?? 0;
        public double GaugeShapePointer => SelectedDegree?.FilledSeats - (SelectedDegree?.TotalSeats * 0.026) ?? 0;
        public string AdmittedSeatsByDegree => $"{SelectedDegree?.FilledSeats ?? 0} / {SelectedDegree?.TotalSeats ?? 0}";
        public int RemainingVacancies => Math.Max(0, (SelectedDegree?.TotalSeats ?? 0) - (SelectedDegree?.FilledSeats ?? 0));
        public string ApplicationCloseText
        {
            get
            {
                int addDays = SelectedDegree?.Name switch
                {
                    "Medical" => 6,
                    "Engineering" => 7,
                    "Arts & Science" => 9,
                    _ => 4
                };
                var closeUtc = DateTime.UtcNow.AddDays(addDays);
                return $"Applications Close on {closeUtc:MMM dd, yyyy 12:00} UTC";
            }
        }
        public IList<GenderStat> GenderStats => SelectedDegree?.Gender ?? new List<GenderStat>();
        public IList<CountryStat> CountryStats => SelectedDegree?.Countries ?? new List<CountryStat>();
        public IList<SunburstNode> SunburstData { get; }
        public List<Brush> CustomBrushes { get; set; }

        #endregion

        #region Constructor

        public EnrollmentViewModel()
        {
            Degrees = new ObservableCollection<DegreeModel>(CreateStaticDegrees());
            SelectedDegree = Degrees.First(d => d.Name == "Medical");
            SunburstData = BuildSunburst(Degrees);
            CustomBrushes = new List<Brush>() { new SolidColorBrush(Color.FromRgb(76, 195, 208)), new SolidColorBrush(Color.FromRgb(252, 99, 190)), new SolidColorBrush(Color.FromRgb(200, 112, 236)) };
        }

        #endregion

        #region Methods

        private IEnumerable<DegreeModel> CreateStaticDegrees()
        {
            // Medical
            var medical = new DegreeModel
            {
                Name = "Medical",
                FilledSeats = 195,
                TotalSeats = 205,
                Courses = new List<CourseModel>
                {
                    new CourseModel{ Name = "General Medicine", Students = 60 , ProgramTypes = new List<ProgramType>(){ new ProgramType("Cardiology", 40), new ProgramType("Neurology", 20) } },
                    new CourseModel{ Name = "Nursing", Students = 50  },
                    new CourseModel{ Name = "Biomedical Sciences", Students = 45 ,ProgramTypes = new List<ProgramType>(){ new ProgramType("Microbiology", 10), new ProgramType("Biochemistry", 25), new ProgramType("Anatomy & Physiology", 10) } },
                    new CourseModel{ Name = "Pharmacy", Students = 40  },
                },
                Gender = new List<GenderStat>
                {
                    new GenderStat{ Category = "Male",   Count = 80 },
                    new GenderStat{ Category = "Female", Count = 105 },
                    new GenderStat{ Category = "Others", Count = 10 },
                },
                Countries = new List<CountryStat>
                {
                    new CountryStat{ Country = "China",     Count = 40 },
                    new CountryStat{ Country = "Australia", Count = 20 },
                    new CountryStat{ Country = "Kenya",     Count = 30 },
                    new CountryStat{ Country = "Brazil",    Count = 10 },
                    new CountryStat{ Country = "Japan",     Count = 35 },
                    new CountryStat{ Country = "Germany",   Count = 30 },
                    new CountryStat{ Country = "UK",        Count = 30 },
                }
            };

            // Engineering
            var engineering = new DegreeModel
            {
                Name = "Engineering",
                FilledSeats = 230,
                TotalSeats = 287,
                Courses = new List<CourseModel>
                {
                    new CourseModel{ Name = "Computer Engineering", Students = 65 , ProgramTypes = new List<ProgramType>(){ new ProgramType("AI", 40), new ProgramType("Cybersecurity", 25) } },
                    new CourseModel{ Name = "Civil Engineering", Students = 55 },
                    new CourseModel{ Name = "Mechanical Engineering", Students = 60 , ProgramTypes = new List<ProgramType>(){ new ProgramType("Thermal Engineering", 40), new ProgramType("Mechatronics & Robotics", 20) } },
                    new CourseModel{ Name = "Electrical Engineering", Students = 50},
                },
                Gender = new List<GenderStat>
                {
                    new GenderStat{ Category = "Male",   Count = 150 },
                    new GenderStat{ Category = "Female", Count = 70 },
                    new GenderStat{ Category = "Others", Count = 10 },
                },
                Countries = new List<CountryStat>
                {
                    new CountryStat{ Country = "China",     Count = 50 },
                    new CountryStat{ Country = "Australia", Count = 30 },
                    new CountryStat{ Country = "Kenya",     Count = 25 },
                    new CountryStat{ Country = "Brazil",    Count = 15 },
                    new CountryStat{ Country = "Japan",     Count = 40 },
                    new CountryStat{ Country = "Germany",   Count = 35 },
                    new CountryStat{ Country = "UK",        Count = 35 },
                }
            };

            // Arts and Science
            var arts = new DegreeModel
            {
                Name = "Arts & Science",
                FilledSeats = 170,
                TotalSeats = 283,
                Courses = new List<CourseModel>
                {
                    new CourseModel{ Name = "Mathematics", Students = 45  },
                    new CourseModel{ Name = "Science", Students = 40 , ProgramTypes = new List<ProgramType>(){ new ProgramType( "Physics", 20), new ProgramType("Space Science", 20) } },
                    new CourseModel{ Name = "Fine Arts", Students = 35 },
                    new CourseModel{ Name = "Literature", Students = 50 , ProgramTypes = new List<ProgramType>(){ new ProgramType( "English", 40), new ProgramType("French", 10) } },
                },
                Gender = new List<GenderStat>
                {
                    new GenderStat{ Category = "Male",   Count = 70 },
                    new GenderStat{ Category = "Female", Count = 90 },
                    new GenderStat{ Category = "Others", Count = 10 },
                },
                Countries = new List<CountryStat>
                {
                    new CountryStat{ Country = "China",     Count = 30 },
                    new CountryStat{ Country = "Australia", Count = 25 },
                    new CountryStat{ Country = "Kenya",     Count = 15 },
                    new CountryStat{ Country = "Brazil",    Count = 10 },
                    new CountryStat{ Country = "Japan",     Count = 30 },
                    new CountryStat{ Country = "Germany",   Count = 30 },
                    new CountryStat{ Country = "UK",        Count = 30 },
                }
            };

            return new[] { medical, engineering, arts };
        }

        private IList<SunburstNode> BuildSunburst(IEnumerable<DegreeModel> degrees)
        {
            var root = new List<SunburstNode>();
            foreach (var degree in degrees)
            {

                foreach (var course in degree.Courses)
                {
                    if (course.ProgramTypes != null && course.ProgramTypes.Any())
                    {
                        foreach (var program in course.ProgramTypes)
                        {
                            var programNode = new SunburstNode
                            {
                                DegreeName = degree.Name,
                                CourseName = course.Name,
                                ProgramType = program.Course.ToString(),
                                StudentCount = program.StudentCountByCourse
                            };
                            root.Add(programNode);
                        }
                    }
                    else
                    {
                        var courseNode = new SunburstNode
                        {
                            DegreeName = degree.Name,
                            CourseName = course.Name,
                            StudentCount = course.Students
                        };
                        root.Add(courseNode);

                    }
                }
            }

            return root;
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); 

        #endregion
    }
}