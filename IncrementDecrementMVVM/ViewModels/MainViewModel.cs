using IncrementDecrementMVVM.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IncrementDecrementMVVM.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand _incrementCommand;
        private ICommand _decrementCommand;
        private int _value;
        public int Value
        {
            get 
            { 
                return _value; 
            }
            private set 
            { 
                if(_value != value)
                {
                    _value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                }
            }
        }
        public ICommand IncrementCommand { get => _incrementCommand ??= new DelegateCommand(() => Value++, () => Value < 9); }
        public ICommand DecrementCommand { get => _decrementCommand ??= new DelegateCommand(() => Value--, () => Value > 0); }

        public MainViewModel()
        {
            Value = 5;
        }
    }
}
