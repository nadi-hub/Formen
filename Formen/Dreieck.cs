using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Dreieck
    {
        private Linie[] linien = new Linie[3];

        public Dreieck()
        {
            // Initialisierung der 3 Linien
            for (int i = 0; i < 3; i++)
            {
                linien[i] = new Linie();
            }
        }

        public double BerechneUmfang()
        {
            // Beispielhafte Berechnung des Umfangs
            return GetSeitenlaengeA() + GetSeitenlaengeB() + GetSeitenlaengeC();
        }

        public double BerechneFlaeche()
        {
            // Beispielhafte Berechnung der Fläche mit Heron's Formel
            double s = BerechneUmfang() / 2;
            return Math.Sqrt(s * (s - GetSeitenlaengeA()) * (s - GetSeitenlaengeB()) * (s - GetSeitenlaengeC()));
        }

        private double GetSeitenlaengeA()
        {
            return 5.0; // Beispielwert
        }

        private double GetSeitenlaengeB()
        {
            return 6.0; // Beispielwert
        }

        private double GetSeitenlaengeC()
        {
            return 7.0; // Beispielwert
        }
    }

}
