using Plugin.DeviceInfo;
using Xamarin.Forms;

namespace DemoDeviceInfo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		    DeviceName.Text = "DeviceName: " + CrossDeviceInfo.Current.DeviceName;
		    Id.Text = "Id: " + CrossDeviceInfo.Current.Id;
		    Manufacturer.Text = "Manufacturer: " + CrossDeviceInfo.Current.Manufacturer;
		    Model.Text = "Model: " + CrossDeviceInfo.Current.Model;
            Version.Text = "Version: " + CrossDeviceInfo.Current.Version;
		    Platform.Text = "Platform: " + CrossDeviceInfo.Current.Platform.ToString();

        }
	}
}
