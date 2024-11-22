using Microsoft.Extensions.Logging;

namespace FlyOutApp;

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
				fonts.AddFont("Holen Vintage.otf", "Holen");
				fonts.AddFont("RIMONS.ttf", "RIMONS");
				fonts.AddFont("Sarcolenta.ttf", "Sarcolenta");
				fonts.AddFont("Voltaire-Frangela.ttf", "VoltaireFrangela");
				fonts.AddFont("Hibiscus.ttf", "Hibiscus");//Flowery.ttf
				fonts.AddFont("Flowery.ttf", "Flowery");//.ttf
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
