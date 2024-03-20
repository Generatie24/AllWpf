using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTwoClassesCRUD
{
    public class Persoon : INotifyPropertyChanged
    {
        private string naam;
        private int leeftijd;
        public Adres Adres { get; set; }

        public string Naam
        {
            get { return naam; }
            set
            {
                naam = value;
                OnPropertyChanged(nameof(Naam));
            }
        }

        public int Leeftijd
        {
            get { return leeftijd; }
            set
            {
                leeftijd = value;
                OnPropertyChanged(nameof(Leeftijd));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
