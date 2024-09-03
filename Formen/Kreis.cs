using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Kreis : Form
    {
        public double Radius { get; set; }

        public Kreis(double radius)
        {
            Radius = radius;
        }

        public override double BerechneUmfang()
        {
            return 2 * Math.PI * Radius;
        }

        public override double BerechneFlaeche()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
