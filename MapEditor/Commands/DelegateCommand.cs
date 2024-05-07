using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MapEditor.Commands
{
    public class DelegateCommand<T> : ICommand where T : class
    {
        private readonly Predicate<T>? canExecute_;
        private readonly Action<T> execute_;
        bool _canExecuteCache = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="method">The method.</param>
        public DelegateCommand(Action<T> method)
        {
            execute_ = method;
            canExecute_ = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="canExecute">The can execute.</param>
        public DelegateCommand(Action<T> method, Predicate<T>? canExecute)
        {
            execute_ = method;
            canExecute_ = canExecute;
        }
        //Used in Some Item ViewModels
        public bool CanExecute(object? param)
        {
            if (canExecute_ != null)
            {
                T? tParam = param is null ? null : param as T;
                bool tempCanExecute = tParam is not null ? false : canExecute_(tParam!);

                if (_canExecuteCache != tempCanExecute)
                {
                    _canExecuteCache = tempCanExecute;
                    this.RaiseCanExecuteChanged();
                }
            }

            return _canExecuteCache;
        }

        /// <summary>
        /// Raises CanExecuteChanged event to notify changes in command status.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, new EventArgs());
            }
        }

        public void Execute(object? param)
        {
            if (execute_ is not null)
            {
                T? tParam = param is null ? null : param as T;
                execute_.Invoke(tParam!);
            }

            if (OnExecute is not null)
                OnExecute.Invoke(this, noArgs);
        }

        private static EventArgs noArgs = new EventArgs();

        #region ICommand Members

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        public event EventHandler? OnExecute;
        #endregion
    }
}
