using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Rechteck
    {
        // Rechteck hat vier Linien
        private List<Linie> linien;

        public Rechteck()
        {
            linien = new List<Linie>
        {
            new Linie(),
            new Linie(),
            new Linie(),
            new Linie()
        };
        }

        public double BerechneUmfang()
        {
            return 4 * 5; 
        }

        public double BerechneFlaeche()
        {
            return 5 * 5;
        }
    }

}
