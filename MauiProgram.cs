namespace HVAC_APP_3;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<SplashPage>();

        builder.Services.AddSingleton<Cap_CalcPage>();

        builder.Services.AddSingleton<Beer_MePage>();

        builder.Services.AddSingleton<ContactsPage>();

		return builder.Build();
	}
}
