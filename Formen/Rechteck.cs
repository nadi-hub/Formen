using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Rechteck : Form
    {
        public Linie Linie1 { get; set; }
        public Linie Linie2 { get; set; }

        public Rechteck(Linie linie1, Linie linie2)
        {
            Linie1 = linie1;
            Linie2 = linie2;
        }

        public override double BerechneUmfang()
        {
            return 2 * (Linie1.Laenge + Linie2.Laenge);
        }

        public override double BerechneFlaeche()
        {
            return Linie1.Laenge * Linie2.Laenge;
        }
    }
}
