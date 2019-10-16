using System;

namespace SampleWithDI
{
    public class Bird : IPet
    {
        public void Move()
        {
            Console.WriteLine("My bird fly!");
        }
    }
}