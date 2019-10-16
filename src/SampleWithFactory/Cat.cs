using System;

namespace SampleWithFactory
{
    public class Cat : IPet
    {
        public void Move()
        {
            Console.WriteLine("My cat run!");
        }
    }
}