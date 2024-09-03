using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Rechteck
    {
        private Linie[] linien = new Linie[4];

        public Rechteck()
        {
            // Initialisierung der 4 Linien
            for (int i = 0; i < 4; i++)
            {
                linien[i] = new Linie();
            }
        }

        public double BerechneUmfang()
        {
            // Beispielhafte Berechnung des Umfangs
            return 2 * (GetSeitenlaengeA() + GetSeitenlaengeB());
        }

        public double BerechneFlaeche()
        {
            // Beispielhafte Berechnung der Fläche
            return GetSeitenlaengeA() * GetSeitenlaengeB();
        }

        private double GetSeitenlaengeA()
        {
            // Berechnung der Länge der ersten Seite
            return 5.0; // Beispielwert
        }

        private double GetSeitenlaengeB()
        {
            // Berechnung der Länge der zweiten Seite
            return 10.0; // Beispielwert
        }
    }

}
