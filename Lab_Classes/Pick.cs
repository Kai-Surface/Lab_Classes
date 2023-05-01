using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Classes
{
    public class Pick
    {
        enum Instrument { acousticGuitar , electricGuitar , bass}
        Instrument instrument;

        enum Material { celluloid , tortex , ultex , delrin , nylon , stone
        , metal , wood , felt}
        Material material;

        enum Shape { standard , sharpTip , pointy , triangle , sharkFin , jazz
        , teardrop}
        Shape shape;

        int _thickness; //0.40 mm to 1.22 mm

        string generateThickness;

        private Instrument Instrument1 { get => instrument; set => instrument = value; }
        private Material Material1 { get => material; set => material = value; }
        private Shape Shape1 { get => shape; set => shape = value; }
        public int Thickness { get => _thickness; set => _thickness = value; }
        public string GenerateThickness { get => generateThickness; set => generateThickness = value; }

        public Pick(int thickness)
        {
            Random random = new Random();
            int unique = random.Next((int)0.40 , (int)1.22);
            GenerateThickness = unique.ToString();
        }

    }
}
