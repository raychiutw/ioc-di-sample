using Microsoft.Extensions.DependencyInjection;

namespace SampleWithDI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // DI
            var services = new ServiceCollection();
            services.AddScoped<IPet, Bird>();

            var provider = services.BuildServiceProvider();
            var pet = provider.GetService<IPet>();

            pet.Move();
        }
    }
}