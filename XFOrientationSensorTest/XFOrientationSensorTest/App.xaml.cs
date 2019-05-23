using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFOrientationSensorTest
{
	public partial class App : Application
	{
		public delegate void AppOrientationChangedHandler(DisplayOrientation orientation);
		public static event AppOrientationChangedHandler AppOrientationChanged;

		private DisplayOrientation _orientation;

		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();

			_orientation = DeviceDisplay.MainDisplayInfo.Orientation;
			MonitorOrientationChanges();
		}

		private void MonitorOrientationChanges()
		{
			try
			{
				OrientationSensor.Start(SensorSpeed.UI);
				OrientationSensor.ReadingChanged += (object sender, OrientationSensorChangedEventArgs e) =>
				{
					if (_orientation != DeviceDisplay.MainDisplayInfo.Orientation)
					{
						//orientation was changed - send event update
						_orientation = DeviceDisplay.MainDisplayInfo.Orientation;

						if (AppOrientationChanged != null)
						{
							AppOrientationChanged(_orientation);
						}
					}
				};
			}
			catch (Exception ex)
			{

			}
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
