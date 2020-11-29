using System.Collections.ObjectModel;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System.Text;
using System.Windows.Input;   

namespace Pinterestclone.ViewModel
{
    public class LandingViewModel : Base
    {
        public LandingViewModel()
        {
            adverts = GetAdverts();
        }

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
        public Advert selectedAdvert
        {
            get { return selectedAdvert; }
            set
            {
                selectedAdvert = value;
                onPropertyChanged();
            }
        }
        public ICommand SelectionCommand => new Command(DisplayAdvert);

     private void DisplayAdvert()
        {
            if (selectedAdvert !=null)
            {
                var Base = AdvertDetails { selectedAdvert=selectedAdvert, Adverts =adverts, Position =adverts.IndexOf(selectedAdvert) };
                var detailsPage = new DetailsPage { BindingContext = Base };

                var navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(detailsPage, true);
            }
        }


         private ObservableCollection<Advert> GetAdverts()
       {
            return new ObservableCollection<Advert>
             {
            new Advert { Name = "Book", Description = "A book about dogs", Image = "Book.png" };
            new Advert { Name = "Book", Description = "A book about dogs", Image = "Cabinet.png" };
            new Advert { Name = "Book", Description = "A book about dogs", Image = "Cabinet2.png" };
            new Advert { Name = "Book", Description = "A book about dogs", Image = "Medicine.png" };
            new Advert { Name = "Book", Description = "A book about dogs", Image = "Recipe.png" };
            new Advert { Name = "Book", Description = "A book about dogs", Image = "Table.png" };

         }

        }
    }  
}
