using System.Globalization;

namespace FlyOutApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        CultureInfo.CurrentCulture = new CultureInfo("es-US"); // For French, change as needed
        CultureInfo.CurrentUICulture = new CultureInfo("es-US");

        MainPage = new AppShell();
	}
}
