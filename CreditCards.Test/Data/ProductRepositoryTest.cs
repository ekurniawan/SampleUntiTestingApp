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
            IList<Product> products = new List<Product>()
            {
                new Product {ProductId=1,Name="ASP Core Fundamentals",Description="ASP Core Fundamentals",Price=49.99},
                new Product {ProductId=2,Name="TDD Fundamentals",Description="TDD Fundamentals",Price=60},
                new Product {ProductId=3,Name="Unit Testing in Action",Description="Unit Testing in Action",Price=50}
            };
            
            Mock<IProductRepository> mockProductRepo = new Mock<IProductRepository>();

            //return semua product
            mockProductRepo.Setup(m => m.FindAll()).Returns(products);
            
            //return product by id
            mockProductRepo.Setup(m => m.FindById(
                It.IsAny<int>())).Returns((int i)=>products.Where(x=>x.ProductId==i).Single());

            mockProductRepo.Setup(m => m.FindByName(It.IsAny<string>()))
                .Returns((string s) => products.Where(x => x.Name == s).Single());

            mockProductRepo.Setup(m => m.Save(It.IsAny<Product>()))
                .Returns((Product target) =>
                {
                    DateTime now = DateTime.Now;
                    if (target.ProductId.Equals(default(int))){
                        target.DateCreated = now;
                        target.DateModified = now;
                        target.ProductId = products.Count() + 1;
                        products.Add(target);
                    }
                    else
                    {
                        var original = products.Where(
                            q=>q.ProductId==target.ProductId).Single();
                        if (original == null) return false;
                        original.Name = target.Name;
                        original.Price = target.Price;
                        original.Description = target.Description;
                        original.DateModified = now;
                    }
                    return true;
                });
            this.MockProductsRepository = mockProductRepo.Object;
        }
    }
}
