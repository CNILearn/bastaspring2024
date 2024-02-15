namespace UnoMauiIntegration;

public static class AppBuilderExtensions
{
    public static MauiAppBuilder UseMauiControls(this MauiAppBuilder builder) =>
        builder
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("UnoMauiIntegration/Assets/Fonts/OpenSansRegular.ttf", "OpenSansRegular");
                fonts.AddFont("UnoMauiIntegration/Assets/Fonts/OpenSansSemibold.ttf", "OpenSansSemibold");
            });
}
