using System.Collections.Generic;

namespace SampleWithUnity.Repository
{
    public interface IProductRepository
    {
        IEnumerable<string> GetAll();
    }
}