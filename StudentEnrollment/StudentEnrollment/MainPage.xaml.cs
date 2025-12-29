
namespace StudentEnrollment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
#if ANDROID || IOS && !MACCATALYST
            Content = new ScrollView
            {
                Content = MainGrid
            };
#endif
        }
    }
}
