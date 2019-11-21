using System;
using System.Windows.Input;

namespace ViewModel
{
    public class Command : ICommand
    {
        public Command(Action execute)
        {
            this.execute = execute;
        }

        private Action execute;

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true; // Kommando darf IMMER ausgeführt werden ;)
        }
        public void Execute(object parameter)
        {
            execute();
        }
    }
}
