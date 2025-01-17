﻿using System.Collections.ObjectModel;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System.Text;
using System.Windows.Input;
using Pinterestclone.Model;
using DocumentFormat.OpenXml.Drawing;

namespace Pinterestclone.ViewModel
{
    public class LandingViewModel : BaseViewModel
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
        public Advert SelectedAdvert
        {
            get { return selectedAdvert; }
            set
            {
                selectedAdvert = value;
                OnPropertyChanged();
            }
        }
        public ICommand SelectionCommand => new Command(DisplayAdvert);

        public void DisplayAdvert()
        {
            if (selectedAdvert != null)
            {
                var viewModel = new DetailsViewModel { SelectedAdvert = selectedAdvert, Adverts = adverts, Position = adverts.IndexOf(selectedAdvert) };
                var detailsPage = new DetailsPage { BindingContext = viewModel };

             var navigation = Application.Current.MainPage as NavigationPage;
              navigation.PushAsync(detailsPage, true);
            }
        }
         private ObservableCollection<Advert> GetAdverts()
         {
            return new ObservableCollection<Advert>
            {
            new Advert { Name = "Book", Description = "A book about dogs", Image = "Book.png" },
            new Advert { Name = "Cabinet", Description = "Customised Cabinets", Image = "Cabinet.png" },
            new Advert { Name = "Cabinet", Description = "For all your cabinet needs", Image = "Cabinet2.png" },
            new Advert { Name = "Keep Health", Description = "Keep a health lifestyle", Image = "Medicine.png" },
            new Advert { Name = "Food hecks", Description = "Recipes on the go", Image = "Recipe.png" },
            new Advert { Name = "Used Tables", Description = "Vintage tables", Image = "Table.png" },

            };

         }
    }  
}
