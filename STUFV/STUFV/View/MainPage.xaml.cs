using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace STUFV
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			Detail = new NavigationPage (new ContentPage ());
			this.IsPresented = true;
		}

		public void onClick1(object sender,EventArgs e)
		{
			Detail = new NavigationPage (new EventOverviewView ());
			this.IsPresented = false;
		}

		public void onClick2(object sender,EventArgs e)
		{
			Detail = new NavigationPage (new LifeSaversView ());
			this.IsPresented = false;
		}

		public void onClick3(object sender,EventArgs e)
		{
			Detail = new NavigationPage (new TransportView ());
			this.IsPresented = false;
		}
		public void onClick4(object sender,EventArgs e)
		{
			Detail = new NavigationPage (new InfoView ());
			this.IsPresented = false;
		}

		public void onClick5(object sender,EventArgs e)
		{
			Detail = new NavigationPage (new AlcoholView ());
			this.IsPresented = false;
		}

		public void onClick6(object sender,EventArgs e)
		{
			Detail = new NavigationPage (new NewsOverviewView ());
			this.IsPresented = false;
		}
		public void onClick7(object sender,EventArgs e)
		{
			Detail = new NavigationPage (new SettingsView ());
			this.IsPresented = false;
		}
	}
}

