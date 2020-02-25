using System.Collections.Generic;
using SampleWithUnity.Repository;

namespace SampleWithUnity.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IEnumerable<string> GetAll()
        {
            return this._productRepository.GetAll();
        }
    }
}