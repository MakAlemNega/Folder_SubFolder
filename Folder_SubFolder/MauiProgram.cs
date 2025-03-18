using Microsoft.Extensions.Logging;
using Syncfusion.Licensing;
using Syncfusion.Maui.Core.Hosting;
using static Folder_SubFolder.MainPage;
using Syncfusion.Maui.TreeView;

namespace Folder_SubFolder;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWXxfeHRUQ2VYVkVwWEA=");
        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.ConfigureSyncfusionCore();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
	}
}
