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
            AnimateBannerLoop();
        }
    }

    private async void AnimateBannerLoop()
    {
#if WINDOWS || MACCATALYST
        while (_isAnimating)
        {
            if (Banner != null)
            {
                await Banner.ScaleToAsync(1.05, 600, Easing.CubicInOut);
                await Banner.ScaleToAsync(0.95, 600, Easing.CubicInOut);
                await Task.Delay(200); // Optional pause between pulses
            }
            else
            {
                break; // Exit the loop if Banner is null
            }
        }
#endif
    }
}