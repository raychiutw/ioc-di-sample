using System;

namespace SampleWithFactory
{
    public class Bird : IPet
    {
        public void Move()
        {
            Console.WriteLine("My bird fly!");
        }
    }
}