using MapEditor.Commands;
using MapEditor.Model;
using System.ComponentModel;
using System.Data.Common;
using System.Reflection;
using System.Windows;
using System.Windows.Input;

namespace MapEditor.ViewModel
{
    public class GeneralTabViewModel: INotifyPropertyChanged
    {

        public ICommand RadioButtonCommand { get; set; }
        public ICommand TextChangedCommand { get; private set; }
        GeneralTabModelcs model = new GeneralTabModelcs();
        

        public GeneralTabViewModel()
        {
            //RadioButtonCommand = new DelegateCommand();
           
            TextChangedCommand = new DelegateCommand<object>(TextboxTextChangedEvent);

        }
        private string _device = "Default";
        public string Device
        {
            get
            {
                return _device;
            }
            set
            {
                _device = value;
               // OnPropertyRaised("Device");
            }
        }
        
        private int _diameter = 8;
        public int Diameter
        {
            get
            {
                return _diameter;
            }
            set
            {
                _diameter = value;
               // OnPropertyRaised("Diameter");

            }
        }

        private int _dieWidth = 1000;
        public int DieWidth
        {
            get
            {
                return _dieWidth;
            }
            set
            {
                _dieWidth = value;
                // OnPropertyRaised("DieWidth");

            }
        }
        private int _dieHeight = 1000;
        public int DieHeight
        {
            get
            {
                return _dieHeight;
            }
            set
            {
                _dieHeight = value;
                // OnPropertyRaised("DieHeight");

            }
        }

        private int _gridheight=7;
        public int GridHeight 
        {
            get
            {
                return _gridheight;
            }
            set
            {
                _gridheight = value;
                OnPropertyRaised("GridHeight");
                
            }
        }
    //    private void ExecuteSetGenderCommand(object commandParameter)
    //=> this.Gender = (Gender)commandParameter;

        private int _gridwidth=7;
        public int GridWidth
        {
            get
            {
                return _gridwidth;
            }
            set
            {
                _gridwidth = value;
                OnPropertyRaised("GridWidth");
            }
        }
        private int _positionX=1;
        public int PositionX
        {
            get
            {
                return _positionX;
            }
            set
            {
                _positionX = value;
                OnPropertyRaised("PositionX");
            }
        }
        private int _positionY=1;
        public int PositionY
        {
            get
            {
                return _positionY;
            }
            set
            {
                _positionY = value;
                OnPropertyRaised("PositionY");
            }
        }

        
         private int _nochRotation;
        public int NochRotation
        {
            get
            {
                return _nochRotation;
            }
            set
            {
                _nochRotation = value;
                OnPropertyRaised("NochRotation");
            }
        }

        private void TextboxTextChangedEvent(object parameter)
        {
            int param1 = GridHeight;
            int param2 = GridWidth;

            model.CreateCirclesWithNotch(param1, param2);

            //MessageBox.Show("Mouse enter event is fired");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
    class DelegateCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;
    private readonly Action<object> _execute;

    public event EventHandler CanExecuteChanged;

    public DelegateCommand(Action<object> execute)
    {
        _execute = execute;
    }

    public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
    {
        _execute = execute;
        _canExecute = canExecute;
    }



    public bool CanExecute(object parameter)
    {
        if (_canExecute == null)
        {
            return true;
        }

        return _canExecute(parameter);
    }

    public void Execute(object parameter)
    {
        _execute(parameter);
    }

    public void RaiseCanExecuteChanged()
    {
        if (CanExecuteChanged != null)
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
    }
}

}
