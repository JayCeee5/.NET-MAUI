using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShope.ViewModel
{
    public class BasePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChange(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected bool SetProperty<T>(ref T prop, T value, [CallerMemberName] String propertyName = null)
        {
            if (Object.Equals(prop, value))
            {
                return false;
            }

            prop = value;
            this.RaisePropertyChange(propertyName);
            return true;
        }
    }
}
