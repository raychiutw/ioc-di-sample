namespace SampleWithInterface
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IPet pet = new Cat();
            pet.Move();
        }
    }
}