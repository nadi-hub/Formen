using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Formenbehaelter
    {
        public List<Rechteck> Rechtecke { get; set; } = new List<Rechteck>();
        public List<Dreieck> Dreiecke { get; set; } = new List<Dreieck>();
        public List<Kreis> Kreise { get; set; } = new List<Kreis>();

        public void AddiereForme(Form form)
        {
            if (form is Rechteck rechteck)
            {
                if (Rechtecke.Count < 2)
                    Rechtecke.Add(rechteck);
            }
            else if (form is Dreieck dreieck)
            {
                if (Dreiecke.Count < 4)
                    Dreiecke.Add(dreieck);
            }
            else if (form is Kreis kreis)
            {
                if (Kreise.Count < 3)
                    Kreise.Add(kreis);
            }
        }

        public void EntferneForme(Form form)
        {
            if (form is Rechteck rechteck)
            {
                Rechtecke.Remove(rechteck);
            }
            else if (form is Dreieck dreieck)
            {
                Dreiecke.Remove(dreieck);
            }
            else if (form is Kreis kreis)
            {
                Kreise.Remove(kreis);
            }
        }

        public List<Form> GetFormen()
        {
            List<Form> formen = new List<Form>();
            formen.AddRange(Rechtecke);
            formen.AddRange(Dreiecke);
            formen.AddRange(Kreise);
            return formen;
        }
    }
}
