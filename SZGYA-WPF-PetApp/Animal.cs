using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SZGYA_WPF_PetApp
{
    public class Animal
    {
        private string _imgpath;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Visibility extendedDataVisibility
        {
            get { return showExtendedData ? Visibility.Visible : Visibility.Collapsed; }
        }

        public bool showExtendedData { get; set; } = false;
        public string ImgPath 
        { 
            get
            {
                string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); // csúnya, de wpf resource embeddinghez nincs idő
                return $"{path}\\..\\..\\..\\src\\IMAGES\\{_imgpath}";
            } 
            set 
            {
                _imgpath = value;    
            } 
        } 
        public Animal(string line) 
        {
            string[] data = line.Split(';');
            Name = data[0];
            Age = int.Parse(data[1]);
            Color = data[2];
            ImgPath = data[3];
            showExtendedData = false;
        }
    }
}
