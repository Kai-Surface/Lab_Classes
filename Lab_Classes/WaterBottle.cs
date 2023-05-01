using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Classes
{
    internal class WaterBottle
    {
        int size;

        string brand;

        string color;

        bool insulated; //Is the bottle insulated or not

        bool filter; //Does the bottle have a filter

        enum Material { singlePlastic, reusablePlastic, glass, metal }
        Material material;

        enum Lid { screwTop , popTop , flipTop , straw , spout }
        Lid lid;

        public int Size { get => size; set => size = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Color { get => color; set => color = value; }
        public bool Insulated { get => insulated; set => insulated = value; }
        public bool Filter { get => filter; set => filter = value; }
        private Material Material1 { get => material; set => material = value; }
        private Lid Lid1 { get => lid; set => lid = value; }
    }
}
