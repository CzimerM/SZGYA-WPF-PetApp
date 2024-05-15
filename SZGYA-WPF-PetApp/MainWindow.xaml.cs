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

        public MainWindow()
        {
            var sr = new StreamReader("../../../src/animals.txt");
            while (!sr.EndOfStream) 
            { 
                animals.Add(new Animal(sr.ReadLine()));
            }
            sr.Close();
            animals.Sort(a => a.Name);
            InitializeComponent();
        }
    }
}