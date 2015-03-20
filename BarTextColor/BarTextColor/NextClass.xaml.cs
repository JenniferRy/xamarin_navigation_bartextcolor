using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BarTextColor
{
	public partial class NextClass : ContentPage
	{
		public NextClass()
		{
			InitializeComponent();
			Title = "Next ClasS";
			RootPage.navigationPage.BarTextColor = Color.Red;
			RootPage.navigationPage.BarBackgroundColor = Color.Green;
		}
	}
}

