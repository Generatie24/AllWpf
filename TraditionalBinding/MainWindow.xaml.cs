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

namespace TraditionalBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Persoon persoon = new Persoon();

        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            persoon.Naam = txtNaam.Text;
            persoon.Leeftijd = int.Parse(txtLeeftijd.Text);  // Zorg voor foutafhandeling in een echte toepassing

            MessageBox.Show($"Naam: {persoon.Naam}, Leeftijd: {persoon.Leeftijd}");
        }
    }
}