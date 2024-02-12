namespace MAUIAppAccelerator;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()
			.UseMauiCommunityToolkitMediaElement()
			.UseMauiMaps()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDetailViewModel>();
		builder.Services.AddTransient<ListDetailDetailPage>();

		builder.Services.AddSingleton<ListDetailViewModel>();

		builder.Services.AddSingleton<ListDetailPage>();

		builder.Services.AddSingleton<DrawingViewModel>();

		builder.Services.AddSingleton<DrawingPage>();

		builder.Services.AddSingleton<MapViewModel>();

		builder.Services.AddSingleton<MapPage>();

		builder.Services.AddSingleton<MediaElementViewModel>();

		builder.Services.AddSingleton<MediaElementPage>();

		builder.Services.AddSingleton<WebViewViewModel>();

		builder.Services.AddSingleton<WebViewPage>();

		builder.Services.AddSingleton<SampleViewModel>();

		builder.Services.AddSingleton<SamplePage>();

		builder.Services.AddSingleton<LottieViewModel>();

		builder.Services.AddSingleton<LottiePage>();

		// TODO: Add App Center secrets
		AppCenter.Start(
			"windowsdesktop={Your Windows App secret here};" +
			"android={Your Android App secret here};" +
			"ios={Your iOS App secret here};" +
			"macos={Your macOS App secret here};",
			typeof(Analytics), typeof(Crashes));

		return builder.Build();
	}
}
