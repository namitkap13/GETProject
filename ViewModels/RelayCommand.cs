using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFLogin.ViewModels
{
    internal class RelayCommand : ICommand
    {
        //Fields 
        private readonly Action<object> _executeAction;
        private readonly Predicate<object>? _canExecuteAction;


        /*Here we have defined a field of type action to execute the commands the action delegate is used to encapsulate a method that is we can pass a method
        as a parameter then we have defined another feild of type predicate to determine if the action can be executed or not this delegate allows te control
        to be  enabled or disabled based on whether its command can be executed*/ 
        
        //Constructors
        public RelayCommand(Action<object> executeAction)  //Since not all commands have to be validated to determine if the action should be executed 
        {
            _executeAction = executeAction;
            _canExecuteAction = null;
        }
        public RelayCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        } 

        //Events
        public event EventHandler? CanExecuteChanged 
        /*Here we can subscribe or unsubscribe Requery suggested event is needed for this we use the command manager the 
          requery suggested event occurs when the command manager detects execution condition has changed*/ 
        {
            add { CommandManager.RequerySuggested+= value; }
            remove { CommandManager.RequerySuggested -= value;}
        }

        //Methods
        /* If the can execute field is null we return true since the validation predicate has not been established otherwise we return the value of delegate that is the
         * method that is going to be defined and delegated in the view model*/  
        public bool CanExecute(object? parameter)
        {
            return _canExecuteAction != null ? _canExecuteAction(parameter) : true;
        }
        /*finally in the execute method we simply execute the action in the same way his will execute the method that is going to be delegated to view model*/
        public void Execute(object? parameter)
        {
            _executeAction(parameter);
        }
    }
}
