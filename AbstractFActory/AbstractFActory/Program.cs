namespace AbstractFActory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IModeOfMovement mode = new BigAnimals();
            IAvesInterface aves = mode.Movement();
            aves.AnimalDescription();
            IReptaliaInterface rep = mode.Movement2();
            rep .AnimalDescription();   

            IModeOfMovement modeOfMovement = new SmallAnimala();
           IAvesInterface ave = modeOfMovement.Movement();
            ave.AnimalDescription();
            IReptaliaInterface rept = modeOfMovement.Movement2();   
            rept.AnimalDescription();
        }
    }
}