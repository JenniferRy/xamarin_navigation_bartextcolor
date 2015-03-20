using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace BarTextColor
{
	public class RootPage : MasterDetailPage
	{
		public static NavigationPage navigationPage;

		public RootPage()
		{
			Master = new ContentPage {
				Title = "Menue",
				Content = new StackLayout {
				}
			};

			var button = new Button{
				Text = "button"
			};

			button.Clicked += (sender, e) => { 
				navigationPage.PushAsync(new NextClass());
			};

			navigationPage = new NavigationPage(new ContentPage {
				Title = "Start",
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						button
					}
				} 
			});

			navigationPage.BarBackgroundColor = Color.Yellow;
			navigationPage.BarTextColor = Color.Pink;

			Detail = navigationPage;
		}
	}
}

