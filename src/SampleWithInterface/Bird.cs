using System;

namespace SampleWithInterface
{
    public class Bird : IPet
    {
        public void Move()
        {
            Console.WriteLine("My bird fly!");
        }
    }
}