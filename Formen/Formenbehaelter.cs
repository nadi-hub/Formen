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
        }

        public Dreieck[] Dreiecke
        {
            get { return dreiecke; }
        }

        public Kreis[] Kreise
        {
            get { return kreise; }
        }

        public Rechteck[] Rechtecke
        {
            get { return rechtecke; }
        }

        public void FuegeDreieckHinzu(Dreieck dreieck)
        {
            for (int i = 0; i < dreiecke.Length; i++)
            {
                if (dreiecke[i] == null)
                {
                    dreiecke[i] = dreieck;
                    break;
                }
            }
        }

        public void FuegeKreisHinzu(Kreis kreis)
        {
            for (int i = 0; i < kreise.Length; i++)
            {
                if (kreise[i] == null)
                {
                    kreise[i] = kreis;
                    break;
                }
            }
        }

        public void FuegeRechteckHinzu(Rechteck rechteck)
        {
            for (int i = 0; i < rechtecke.Length; i++)
            {
                if (rechtecke[i] == null)
                {
                    rechtecke[i] = rechteck;
                    break;
                }
            }
        }
    }



}
