using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTwoClassesCRUD
{
    public class PersonenManager
    {
        public ObservableCollection<Persoon> Personen { get; private set; }

        public PersonenManager()
        {
            Personen = new ObservableCollection<Persoon>();
            SeedData();
        }

        private void SeedData()
        {
            Personen.Add(new Persoon { Naam = "Rik", Leeftijd = 30, Adres = new Adres { Straat = "Hoofdstraat", Stad = "Brussel" } });
            Personen.Add(new Persoon { Naam = "Zak", Leeftijd = 25, Adres = new Adres { Straat = "Zijstraat", Stad = "Antwerpen" } });
            Personen.Add(new Persoon { Naam = "Gabriela", Leeftijd = 27, Adres = new Adres { Straat = "Zondernaam", Stad = "Gent" } });
            Personen.Add(new Persoon { Naam = "Hugo", Leeftijd = 26, Adres = new Adres { Straat = "Stationstraat", Stad = "Kortrijk" } });
        }
    }
}
