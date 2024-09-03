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

        public double BerechneUmfang()
        {
            double radius = GetRadius();
            return 2 * Math.PI * radius;
        }

        public double BerechneFlaeche()
        {
            double radius = GetRadius();
            return Math.PI * radius * radius;
        }

        private double GetRadius()
        {
            return 5.0; // Beispielwert
        }
    }

}
