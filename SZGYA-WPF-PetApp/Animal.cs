using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_PetApp
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string ImgPath { get; set; } 
        public Animal(string line) 
        {
            string[] data = line.Split(';');
            Name = data[0];
            Age = int.Parse(data[1]);
            Color = data[2];
            ImgPath = data[3];
        }
    }
}
