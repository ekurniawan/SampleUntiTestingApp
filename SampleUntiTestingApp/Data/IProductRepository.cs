using SampleUntiTestingApp.Models;
using System.Collections.Generic;

namespace SampleUntiTestingApp.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> FindAll();
        Product FindByName(string productName);
        Product FindById(int productId);
        bool Save(Product target);
    }
}
