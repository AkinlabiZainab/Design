namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the kind or grain you want to learn about, ");
            Console.WriteLine("enter 1 for rice, 2 for pasta, 3 for coucous");
             int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                Type Type = new Type();
                Type.RiceMaking();
                Procedure procedure = new Procedure();
                procedure.RiceMaking();
            }
            else if(input == 2) 
            {
                Type Type = new Type();
                Type.PastaMaking();
                Procedure procedure = new Procedure();
                procedure.PastaMaking();
            }
            else if (input == 3)
            {
                Type Type = new Type();
                Type.CousCousMaking();
                Procedure procedure = new Procedure();
                procedure.CousCousMaking();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}