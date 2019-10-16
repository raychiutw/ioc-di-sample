namespace SampleWithFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IPet pet = PetFactory.GetPet("Bird");
            pet.Move();
        }
    }
}