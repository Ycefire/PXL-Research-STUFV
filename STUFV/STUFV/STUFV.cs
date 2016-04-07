using System;

using Xamarin.Forms;

namespace STUFV
{
	public class App : Application
	{

		//public static NavigationPage NavPage = null;

		public App ()
		{
			// The root page of your application
			MainPage = new STUFV.MainPage();
//			NavPage = new NavigationPage(new STUFV.MainPage().Master);
//
//			MainPage = NavPage;
//
//			var master = new STUFV.MainPage();
//			var detail = new NavigationPage(new EventOverviewView());
//
//			if (App.Navigation == null)
//			{
//				App.Navigation = detail.Navigation;
//			}
//

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

