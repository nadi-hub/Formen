namespace Formen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Linie l1 = new Linie(5);
            Linie l2 = new Linie(10);
            Linie l3 = new Linie(7);
            Linie l4 = new Linie(7);

            
            Rechteck rechteck1 = new Rechteck(l1, l2);
            Rechteck rechteck2 = new Rechteck(l3, l4);
            Dreieck dreieck1 = new Dreieck(l1, l2, l3);
            Kreis kreis1 = new Kreis(5);
            Kreis kreis2 = new Kreis(7);

            
            Formenbehaelter formenbehaelter = new Formenbehaelter();
            formenbehaelter.AddiereForme(rechteck1);
            formenbehaelter.AddiereForme(rechteck2);
            formenbehaelter.AddiereForme(dreieck1);
            formenbehaelter.AddiereForme(kreis1);
            formenbehaelter.AddiereForme(kreis2);

            
            Console.WriteLine("Anzahl der Rechtecke im Formenbehaelter: " + formenbehaelter.Rechtecke.Count);
            Console.WriteLine("Anzahl der Dreiecke im Formenbehaelter: " + formenbehaelter.Dreiecke.Count);
            Console.WriteLine("Anzahl der Kreise im Formenbehaelter: " + formenbehaelter.Kreise.Count);
        }
    }

}

