namespace TestDummy;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();

      // Get the package name (on Android) or bundle identifier (on iOS/macOS)
      string packageName = AppInfo.Current.PackageName;

      infos.Text = $"Package Name: {packageName}\n" +
                   $"App Name: {AppInfo.Current.Name}\n" +
                   $"Version: {AppInfo.Current.VersionString}\n" +
                   $"Build: {AppInfo.Current.BuildString}\n" +
                   $"Platform: {DeviceInfo.Current.Platform}\n" +
                   $"Device Model: {DeviceInfo.Current.Model}\n" +
                   $"Manufacturer: {DeviceInfo.Current.Manufacturer}\n" +
                   $"Device Name: {DeviceInfo.Current.Name}\n" +
                   $"OS Version: {DeviceInfo.Current.VersionString}\n" +
                   $"Idioms: {DeviceInfo.Current.Idiom}\n" +
                   $"Device Type: {DeviceInfo.Current.DeviceType}";
   }
}
