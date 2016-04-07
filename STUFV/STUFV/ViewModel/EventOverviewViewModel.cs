using System;
using System.ComponentModel;

namespace STUFV
{
	public class EventOverviewViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;


		public EventOverviewViewModel ()
		{
		}

		private void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

