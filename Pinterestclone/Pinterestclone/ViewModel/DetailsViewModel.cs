using System;
using System.Collections.Generic;
using System.Text;
using Landing;
using Base;


namespace Pinterestclone
{
    public class AdvertDetails : Base
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
            public Advert selectedAdvert
             {
                 get { return selectedAdvert; }
                set
            {
            selectedAdvert = value;
            onPropertyChanged();
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
            {
                Set
                    {
                    position = Value;
                    selectedAdvert = adverts[position];

                    onPropertyChanged();
                    onPropertyChanged(nameof(selectedAdvert));
                }
            }
        }

    }
}
