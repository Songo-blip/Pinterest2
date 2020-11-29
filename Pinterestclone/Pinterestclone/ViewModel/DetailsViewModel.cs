using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Pinterestclone.Model;
using Xamarin.Forms;
using System.Windows.Input;

namespace Pinterestclone.ViewModel
{
    public class DetailsViewModel : BaseViewModel
    { 
  
        ObservableCollection<Advert> adverts;
        public ObservableCollection<Advert> Adverts
     {
        get { return adverts; }
        set
        {
            adverts = value;
            OnPropertyChanged();
        }

     }
         private Advert selectedAdvert;
            public Advert SelectedAdvert
             {
                 get { return selectedAdvert; }
                set
            {
            selectedAdvert = value;
            OnPropertyChanged();
            }
        }

        private int position;
        public int Position
        {
            get
            {
                if (position != adverts.IndexOf(selectedAdvert))
                    return adverts.IndexOf(selectedAdvert);

                return position;
            }
            set
            {
                    position = value;
                    selectedAdvert = adverts[position];

                    OnPropertyChanged();
                    OnPropertyChanged(nameof(SelectedAdvert));
            }
           
        }

    }
}
