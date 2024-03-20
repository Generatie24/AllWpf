using System.ComponentModel;

namespace TTwoClassesCRUD
{
    public class Adres : INotifyPropertyChanged
    {
        private string straat;
        private string stad;

        public string Straat
        {
            get { return straat; }
            set
            {
                straat = value;
                OnPropertyChanged(nameof(Straat));
            }
        }

        public string Stad
        {
            get { return stad; }
            set
            {
                stad = value;
                OnPropertyChanged(nameof(Stad));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
