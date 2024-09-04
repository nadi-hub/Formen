namespace Formen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Formenbehaelter behaelter = new Formenbehaelter();

            Rechteck rechteck = new Rechteck();
            Dreieck dreieck = new Dreieck();
            Kreis kreis1 = new Kreis();
            Kreis kreis2 = new Kreis();

            behaelter.AddiereFormen(rechteck);
            behaelter.AddiereFormen(dreieck);
            behaelter.AddiereFormen(kreis1);
            behaelter.AddiereFormen(kreis2);

            Console.WriteLine("Formen im Behälter:");
            foreach (var form in behaelter.ErhalteFormen())
            {
                Console.WriteLine(form.GetType().Name);
            }
        }
    }
}

