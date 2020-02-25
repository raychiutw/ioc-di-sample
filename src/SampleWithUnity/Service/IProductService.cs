using System.Collections.Generic;

namespace SampleWithUnity.Service
{
    public interface IProductService
    {
        IEnumerable<string> GetAll();
    }
}