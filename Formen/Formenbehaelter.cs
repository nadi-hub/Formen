using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Formenbehaelter
    {
        private Dreieck[] dreiecke;
        private Kreis[] kreise;
        private Rechteck[] rechtecke;

        public Formenbehaelter()
        {
            dreiecke = new Dreieck[4]; // Maximal 4 Dreiecke
            kreise = new Kreis[3]; // 1 bis 3 Kreise
            rechtecke = new Rechteck[2]; // Genau 2 Rechtecke

            // Beispiel: Initialisierung der Formen
            rechtecke[0] = new Rechteck();
            rechtecke[1] = new Rechteck();

            // Optional: Initialisierung von Kreisen und Dreiecken
        }
        public Rechteck[] Rechtecke
        {
            get { return rechtecke; }
        }


    }

}
