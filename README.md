# Connectivity-DeviceInfo-Plugin
Connectivity and Device Info Plugin - Xamarin.Forms

This repository gives usage of the Connectivity and Device Info Plugins Created by James Montemagno

These are the Functions are used in this Xamarin.Forms Application:

* Connectivity Plugin (using Plugin.Connectivity)
  1. CrossConnectivity.Current.IsConnected (returns bool value if the device ic connected to network)

* Device Info Plugin (using Plugin.DeviceInfo)
  1. CrossDeviceInfo.Current.GenerateAppId(bool usingPhoneId = false, string prefix = null, string suffix = null)
  2. CrossDeviceInfo.Current.Id
  3. CrossDeviceInfo.Current.Model
  4. CrossDeviceInfo.Current.Platform
  5. CrossDeviceInfo.Current.Version
