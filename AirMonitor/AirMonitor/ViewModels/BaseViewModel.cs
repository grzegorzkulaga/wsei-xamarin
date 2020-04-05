using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AirMonitor.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
