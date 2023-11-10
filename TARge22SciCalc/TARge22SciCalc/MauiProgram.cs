namespace TARge22SciCalc;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                fonts.AddFont("maui-script.ttf", "Maui");
                fonts.AddFont("Cairo-Light.ttf", "CairoL");
                fonts.AddFont("Cairo-ExtraLight.ttf", "CairoEL");
            });

		return builder.Build();
	}
}

