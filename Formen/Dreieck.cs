using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Dreieck
    {
        private List<Linie> linien;

        public Dreieck()
        {
            linien = new List<Linie>
        {
            new Linie(),
            new Linie(),
            new Linie()
        };
        }

        public double BerechneUmfang()
        {
            return 3 * 5; 
        }
        /// <summary>
        /// Berechnet die Fläche eines Dreiecks mit der gesetzten Länge = 5  und einer gesetzten Höhe = 4.
        /// </summary>
        /// <returns>Die Fläche des Dreiecks als double, basierend auf der Formel 0.5 * Länge * Höhe</returns>
        public double BerechneFlaeche()
        {
            return (double)(0.5 * 5 * 4);
        }
    }


}
