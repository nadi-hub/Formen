using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Formenbehaelter
    {
        private List<Dreieck> dreiecke;
        private List<Kreis> kreise;
        private List<Rechteck> rechtecke;

        public Formenbehaelter()
        {
            dreiecke = new List<Dreieck>();
            kreise = new List<Kreis>();
            rechtecke = new List<Rechteck>();
        }

        public void AddiereFormen(object form)
        {
            if (form is Dreieck && dreiecke.Count < 4)
            {
                dreiecke.Add((Dreieck)form);
            }
            else if (form is Kreis && kreise.Count < 3)
            {
                kreise.Add((Kreis)form);
            }
            else if (form is Rechteck && rechtecke.Count < 2)
            {
                rechtecke.Add((Rechteck)form);
            }
            else
            {
                Console.WriteLine("Maximale Anzahl dieser Form erreicht.");
            }
        }

        public void EntferneFormen(object form)
        {
            if (form is Dreieck && dreiecke.Contains((Dreieck)form))
            {
                dreiecke.Remove((Dreieck)form);
            }
            else if (form is Kreis && kreise.Contains((Kreis)form))
            {
                kreise.Remove((Kreis)form);
            }
            else if (form is Rechteck && rechtecke.Contains((Rechteck)form))
            {
                rechtecke.Remove((Rechteck)form);
            }
        }

        public List<object> ErhalteFormen()
        {
            List<object> formen = new List<object>();
            formen.AddRange(dreiecke);
            formen.AddRange(kreise);
            formen.AddRange(rechtecke);
            return formen;
        }
    }



}
