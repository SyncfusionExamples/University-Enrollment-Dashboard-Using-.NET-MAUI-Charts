namespace StudentEnrollment;

public partial class NoticeData : ContentView
{
    private bool _isAnimating = true;
    public NoticeData()
	{
		InitializeComponent();
        Loaded += NoticeData_Loaded;
    }

    private async void NoticeData_Loaded(object? sender, EventArgs e)
    {
        if(Banner != null)
        {
            await Banner.ScaleTo(1.0, 500, Easing.CubicOut);
            AnimateBannerLoop();
        }
    }

    private async void AnimateBannerLoop()
    {
        while (_isAnimating)
        {
            await Banner.ScaleTo(1.05, 600, Easing.CubicInOut);
            await Banner.ScaleTo(0.95, 600, Easing.CubicInOut);
            await Task.Delay(200); // Optional pause between pulses
        }
    }
}