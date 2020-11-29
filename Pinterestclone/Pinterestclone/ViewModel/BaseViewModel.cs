using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Landing;

namespace Pinterestclone
{
    public class BaseViewModel : INotifyPropertyChanged

    {
        public event PropertyChangeEventHandler PropertyChanged;
        public void onPropertyChange([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new (PropertyChangedEventArgsname)); 
        }
    }
}
