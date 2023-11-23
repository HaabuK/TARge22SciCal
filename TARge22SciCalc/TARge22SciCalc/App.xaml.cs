#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif


using Views;

namespace TARge22SciCalc;

public partial class App : Application
{
	//const int WindowWidth = 540;
	//const int WindowHeight = 1000;

	public App()
	{
        InitializeComponent();

        //#if __MACCATALYST__
        //	Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        //	{
        //		var mauiWindow = handler.VirtualView;
        //		var nativeWindow = handler.PlatformView;
        //		nativeWindow.Activate();
        //		IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
        //		WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
        //		AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
        //		appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
        //	});
        //#endif

        //#if __MACCATALYST__
        //            // This code will be included only when running on macOS with Mac Catalyst

        //            // Create your UI elements
        //            var label = new Label
        //            {
        //                Text = "Hello MAUI on Mac Catalyst!",
        //                FontSize = 50,
        //                HorizontalOptions = LayoutOptions.CenterAndExpand,
        //                VerticalOptions = LayoutOptions.CenterAndExpand
        //            };

        //            // Add UI elements to the layout
        //            var stackLayout = new StackLayout
        //            {
        //                Children = { label }
        //            };

        //            // Set the content of the page
        //            Content = stackLayout;
        //#endif

        MainPage = new CalculatorPage();
	}
}
