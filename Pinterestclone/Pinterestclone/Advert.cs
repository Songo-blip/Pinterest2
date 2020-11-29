using System;
using System.Collections.Generic;
using System.Text;

namespace Pinterestclone
{
    public class Advert
    {
        private string Image;
        private string Description;
        private string Name;

        public List<Advert> Adverts { get; set; }

        public Advert()
        {
            Adverts = new List<Advert>();

            Adverts.Add(new Advert { Name = "Book", Description = "A book about dogs", Image = "Book.png" });

            Adverts.Add(new Advert { Name = "Book", Description = "A book about dogs", Image =  "Cabinet.png" });


            Adverts.Add(new Advert { Name = "Book", Description = "A book about dogs", Image =  "Cabinet2.png"});

            Adverts.Add(new Advert { Name = "Book", Description = "A book about dogs", Image = "Medicine.png"});
 
            Adverts.Add(new Advert { Name = "Book", Description = "A book about dogs", Image =  "Recipe.png"});
           Adverts.Add(new Advert { Name = "Book", Description = "A book about dogs", Image ="Table.png"});
        }
    }
}
