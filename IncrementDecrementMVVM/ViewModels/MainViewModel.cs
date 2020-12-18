using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrementMVVM.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
        public MainViewModel()
        {
            //Value = 5;

            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Value++;
                    Task.Delay(1000).Wait();
                }
            });
        }

        private void Increment()
        {
            _value++;
        }

        private void Decrement()
        {
            _value--;
        }
    }
}
