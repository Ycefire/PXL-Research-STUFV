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
			Detail = new NavigationPage (new Detail1 ());
			this.IsPresented = false;
		}

		public void onClick2(object sender,EventArgs e)
		{
			Detail = new NavigationPage (new Detail2 ());
			this.IsPresented = false;
		}

		public void onClick3(object sender,EventArgs e)
		{
			Detail = new NavigationPage (new Detail3 ());
			this.IsPresented = false;
		}
	}
}

