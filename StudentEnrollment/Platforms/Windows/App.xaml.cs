
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace StudentEnrollment.WinUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : MauiWinUIApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();


        //protected override void OnLaunched(LaunchActivatedEventArgs args)
        //{
        //    base.OnLaunched(args);
        //    try
        //    {
        //        // Get the WinUI Window and its AppWindow, then request FullScreen presenter.
        //        var window = Microsoft.UI.Xaml.Window.Current;
        //        if (window == null)
        //            return;

        //        var hwnd = WindowNative.GetWindowHandle(window);
        //        var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hwnd);
        //        var appWindow = AppWindow.GetFromWindowId(windowId);

        //        if (appWindow != null)
        //        {
        //            // Request full screen mode
        //            appWindow.SetPresenter(AppWindowPresenterKind.FullScreen);
        //        }
        //    }
        //    catch
        //    {
        //        // Ignore exceptions
        //    }

        //}

    }
}
