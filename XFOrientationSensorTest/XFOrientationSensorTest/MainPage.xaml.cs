using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace XFOrientationSensorTest
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(true)]
	public partial class MainPage : ContentPage
	{
        public void Handle_Clicked(object sender, EventArgs e)
		{
			Debug.WriteLine($"MainPage.Handle_Clicked()");
		}

		public MainPage()
		{
			InitializeComponent();
		}
	}
}
