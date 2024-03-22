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
           
            var nieuwePersoon = new Persoon { Naam = txtNaam.Text, Leeftijd = int.Parse(txtLeeftijd.Text), Adres = new Adres { Straat = txtStraat.Text, Stad = txtStad.Text } };
            PersonenManager.Personen.Add(nieuwePersoon);
        }

        private void ClearBoxex()
        {

            txtNaam.Text = string.Empty;
            txtLeeftijd.Text = "";
            txtStraat.Text = "";
            txtStad.Text = "";
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedPersoon = PersonenDataGrid.SelectedItem as Persoon;
            if (selectedPersoon != null)
            {
                selectedPersoon.Naam = txtNaam.Text;
                selectedPersoon.Leeftijd = int.Parse(txtLeeftijd.Text);
                selectedPersoon.Adres.Straat = txtStraat.Text;
                selectedPersoon.Adres.Stad = txtStad.Text;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedPersoon = PersonenDataGrid.SelectedItem as Persoon;
            if (selectedPersoon != null)
            {
                PersonenManager.Personen.Remove(selectedPersoon);
            }
        }

        private void PersonenDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedPersoon = PersonenDataGrid.SelectedItem as Persoon;
            if (selectedPersoon != null)
            {
                txtNaam.Text = selectedPersoon.Naam;
                txtLeeftijd.Text = selectedPersoon.Leeftijd.ToString();
                txtStraat.Text = selectedPersoon.Adres.Straat;
                txtStad.Text = selectedPersoon.Adres.Stad;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearBoxex();
        }
    }
}