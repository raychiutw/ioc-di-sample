using System;

namespace SampleWithDI
{
    public class Cat : IPet
    {
        public void Move()
        {
            Console.WriteLine("My cat run!");
        }
    }
}