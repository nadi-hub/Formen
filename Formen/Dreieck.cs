using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Dreieck : Form
    {
        public Linie Linie1 { get; set; }
        public Linie Linie2 { get; set; }
        public Linie Linie3 { get; set; }

        public Dreieck(Linie linie1, Linie linie2, Linie linie3)
        {
            Linie1 = linie1;
            Linie2 = linie2;
            Linie3 = linie3;
        }

        public override double BerechneUmfang()
        {
            return Linie1.Laenge + Linie2.Laenge + Linie3.Laenge;
        }

        public override double BerechneFlaeche()
        {
            double s = BerechneUmfang() / 2;
            return Math.Sqrt(s * (s - Linie1.Laenge) * (s - Linie2.Laenge) * (s - Linie3.Laenge));
        }
    }
}
