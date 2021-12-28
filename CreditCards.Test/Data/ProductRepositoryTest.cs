using Moq;
using SampleUntiTestingApp.Data;
using SampleUntiTestingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCards.Test.Data
{
    public class ProductRepositoryTest
    {
        public IProductRepository MockProductsRepository { get; private set; }
        public ProductRepositoryTest()
        {
            IEnumerable<Product> products = new List<Product>()
            {
                new Product {ProductId=1,Name="ASP Core Fundamentals",Description="ASP Core Fundamentals",Price=49.99},
                new Product {ProductId=2,Name="TDD Fundamentals",Description="TDD Fundamentals",Price=60},
                new Product {ProductId=3,Name="Unit Testing in Action",Description="Unit Testing in Action",Price=50}
            };
            
            Mock<IProductRepository> mockProductRepo = new Mock<IProductRepository>();
            mockProductRepo.Setup(m => m.FindAll()).Returns(products);
            mockProductRepo.Setup(m => m.FindById(
                It.IsAny<int>())).Returns((int i)=>products.Where(x=>x.ProductId==i).Single());
        }
    }
}
