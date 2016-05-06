using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Domain;
using ServiceWCF;
using Infrastructure;

namespace IntegrationTest
{
    [TestClass]
    public class GetAllProduct
    {
        private ServiceProduct _serviceProduct;
        private readonly int PRODUCTCOUNT = 1;
        private readonly string PRODUCTName = "Fuji";
        private readonly int PRODUCTPrice = 3;
        private IEnumerable<Product> products;

        [TestMethod]
        public void TestGetAll()
        {
            using (var ctx = new UserContext())
            {
                ctx.products.Add(new Product() { Name = "Fuji", Price=3 });
                ctx.SaveChanges();
            }


            Assert.AreEqual(PRODUCTCOUNT, product.ToList().Count;
        }

        [TestInitialize]
        public void setup()
        {
            _productController = new ProductController();
            using (var ctx = new UserContext())
            {
                if (ctx.Database.Exists())
                {
                    ctx.Database.Delete();
                }
                ctx.Database.Create();
            }

        }
    }
}
