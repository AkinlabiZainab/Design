namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton news = new Singleton();
            news.AddDetails("kenny", 40);
        }
    }
}