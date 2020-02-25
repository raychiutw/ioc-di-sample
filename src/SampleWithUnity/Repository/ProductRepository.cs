using System.Collections.Generic;

namespace SampleWithUnity.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }
    }
}