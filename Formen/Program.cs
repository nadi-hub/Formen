namespace Formen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Formenbehaelter formenbehaelter = new Formenbehaelter();

            // Beispiel für die Verwendung der Klassen
            double rechteckUmfang = formenbehaelter.Rechtecke[0].BerechneUmfang();
            double rechteckFlaeche = formenbehaelter.Rechtecke[0].BerechneFlaeche();

            System.Console.WriteLine($"Umfang des ersten Rechtecks: {rechteckUmfang}");
            System.Console.WriteLine($"Fläche des ersten Rechtecks: {rechteckFlaeche}");
        }
    }


}

