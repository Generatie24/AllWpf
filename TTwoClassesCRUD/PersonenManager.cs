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
            Personen.Add(new Persoon { Naam = "Jan", Leeftijd = 30, Adres = new Adres { Straat = "Hoofdstraat", Stad = "Brussel" } });
            Personen.Add(new Persoon { Naam = "Emma", Leeftijd = 25, Adres = new Adres { Straat = "Zijstraat", Stad = "Antwerpen" } });
            // Voeg meer seed data toe indien nodig
        }
    }
}
