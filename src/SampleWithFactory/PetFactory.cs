using System;

namespace SampleWithFactory
{
    public class PetFactory
    {
        public static IPet GetPet(string name)
        {
            switch (name)
            {
                case "Cat":
                    return new Cat();

                case "Bird":
                    return new Bird();

                default:
                    throw new Exception("Missing Name");
            }
        }
    }
}