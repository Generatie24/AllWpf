using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TTwoClassesCRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PersonenManager PersonenManager { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            PersonenManager = new PersonenManager();
            DataContext = PersonenManager;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var nieuwePersoon = new Persoon { Naam = "Nieuwe Naam", Leeftijd = 20, Adres = new Adres { Straat = "Nieuwe Straat", Stad = "Nieuwe Stad" } };
            PersonenManager.Personen.Add(nieuwePersoon);
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Logica voor bijwerken (afhankelijk van de UI en gebruikersinteractie)
            // Deze kan bijvoorbeeld een dialoogvenster openen om de gegevens te bewerken
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedPersoon = PersonenDataGrid.SelectedItem as Persoon;
            if (selectedPersoon != null)
            {
                PersonenManager.Personen.Remove(selectedPersoon);
            }
        }
    }
}