namespace Formen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Formenbehaelter formenbehaelter = new Formenbehaelter();

            // Instanzieren von zwei Rechtecken
            Rechteck rechteck1 = new Rechteck();
            Rechteck rechteck2 = new Rechteck();

            // Instanzieren eines Dreiecks
            Dreieck dreieck = new Dreieck();

            // Instanzieren von zwei Kreisen
            Kreis kreis1 = new Kreis();
            Kreis kreis2 = new Kreis();

            // Hinzufügen der Formen zum Formenbehälter
            formenbehaelter.FuegeRechteckHinzu(rechteck1);
            formenbehaelter.FuegeRechteckHinzu(rechteck2);
            formenbehaelter.FuegeDreieckHinzu(dreieck);
            formenbehaelter.FuegeKreisHinzu(kreis1);
            formenbehaelter.FuegeKreisHinzu(kreis2);

            // Beispielhafte Ausgabe
            System.Console.WriteLine("Formenbehälter erfolgreich instanziert und gefüllt.");
        }
    }


}

