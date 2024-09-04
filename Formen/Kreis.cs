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
            return 2 * (double)Math.PI * 5;
        }

        public double BerechneFlaeche()
        {
            return (double)Math.PI * 5 * 5;
        }
    }

}
