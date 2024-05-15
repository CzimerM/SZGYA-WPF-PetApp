using System.IO;
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

namespace SZGYA_WPF_PetApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Animal> animals = new List<Animal>();
        List<Animal> pets = new List<Animal>();
        public MainWindow()
        {
            InitializeComponent();
            var sr = new StreamReader("../../../src/animals.txt");
            while (!sr.EndOfStream)
            {
                animals.Add(new Animal(sr.ReadLine()));
            }
            sr.Close();
            animals.Sort((a, b) => a.Name.CompareTo(b.Name));

            lstbxAnimal.ItemsSource = animals;
            lstbxPets.ItemsSource = pets;
        }

        void btnCopyClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            pets.Add((Animal)b.DataContext);
            lstbxPets.Items.Refresh();
        }

        void btnDeleteClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Animal toBeDeleted = (Animal)b.DataContext;
            for (int i = pets.Count - 1; i >= 0; i--)
            {
                if (pets[i] == toBeDeleted) pets.RemoveAt(i);
            }
            lstbxPets.Items.Refresh();
        }
    }
}