using System;
using System.Windows.Input;

namespace STUFV
{
	public class CustomCommand : ICommand
	{
		private Action<object> execute;
		private Predicate<object> canExecute;

		public CustomCommand(Action<object> execute, Predicate<object> canExecute)
		{
			this.execute = execute;
			this.canExecute = canExecute;
		}

		public event EventHandler CanExecuteChanged;

		/* Ik heb een RaiseCanExecuteChanged method toegevoegd aangezien in de eventhandler van CanExecutechanged
           ik de CommandManager niet kon gebruiken -> niet mogelijk in combinatie met silverlight
           Method wordt aangeroepen wanneer er een variable verandert indien deze variable betrekking heeft
           op dat command. */

		public void RaiseCanExecuteChanged()
		{
			EventHandler handler = CanExecuteChanged;
			if (handler != null)
				handler(this, EventArgs.Empty);
		}

		public bool CanExecute(object parameter)
		{
			bool b = canExecute == null ? true : canExecute(parameter);
			return b;
		}

		public void Execute(object parameter)
		{
			execute(parameter);
		}
	}
}