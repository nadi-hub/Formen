using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Kreis
    {
        private Linie linie;

        public Kreis()
        {
            linie = new Linie();
        }
        /// <summary>
        /// Die Methode berechnet den Umfang vom Kreis mit dem gesetzten Radius = 5. 
        /// </summary> 
        /// <returns>Der Umfang des Kreises als double, basierend auf der Formel 2 * π * r, wobei der Radius 5 ist.</returns>
        public double BerechneUmfang()
        {
            return 2 * (double)Math.PI * 5;
        }

        public double BerechneFlaeche()
        {
            return (double)Math.PI * 5 * 5;
        }
    }

}
