using System;

namespace SampleWithInterface
{
    public class Cat : IPet
    {
        public void Move()
        {
            Console.WriteLine("My cat run!");
        }
    }
}