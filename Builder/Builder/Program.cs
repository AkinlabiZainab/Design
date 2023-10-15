namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            KolaHouse kola = new();
            Contractor cont = new();
            House house = cont.Contractors(kola);
            house.DisplayHouse();
        }

    }
}