using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ConnectivityDeviceinfo
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Padding=20,
                    Children = {
                        new Label {Text ="Device OS: " +  Device.OS.ToString() + Device.Idiom.ToString() },
                        new Label { Text = "IsConnected: " + Plugin.Connectivity.CrossConnectivity.Current.IsConnected.ToString() },
                        new Label { Text = "Platform: "+ Plugin.DeviceInfo.CrossDeviceInfo.Current.Platform.ToString()},
                        new Label{ Text = "Generated AppId: " + Plugin.DeviceInfo.CrossDeviceInfo.Current.GenerateAppId()},
                        new Label{ Text = "Generated AppId: " + Plugin.DeviceInfo.CrossDeviceInfo.Current.GenerateAppId(true)},
                        new Label{ Text = "Generated AppId: " + Plugin.DeviceInfo.CrossDeviceInfo.Current.GenerateAppId(true, "hello")},
                        new Label{ Text = "Generated AppId: " + Plugin.DeviceInfo.CrossDeviceInfo.Current.GenerateAppId(true, "hello", "world")},
                        new Label{ Text = "Id: " + Plugin.DeviceInfo.CrossDeviceInfo.Current.Id},
                        new Label{ Text = "Model: " + Plugin.DeviceInfo.CrossDeviceInfo.Current.Model},
                        new Label{ Text = "Platform: " + Plugin.DeviceInfo.CrossDeviceInfo.Current.Platform},
                        new Label{ Text = "Version: " + Plugin.DeviceInfo.CrossDeviceInfo.Current.Version},
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
