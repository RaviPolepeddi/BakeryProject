using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryProj;

namespace BakeryTestProject
{
    [TestClass]
    public class UnitTestVegimiteScroll
    {
        [TestMethod]
        public void CalculateVegimiteScroll()
        {
            var quantity = 10;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("VS5");
            var result = prod.Calculate(quantity);
            Assert.IsTrue(result.Contains("2 x 5 $6.99"));
        }

        [TestMethod]
        public void CalculateVegimiteScrollwithIncorrectValue()
        {
            var quantity = 14;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("VS5");
            var result = prod.Calculate(quantity);
            Assert.IsFalse(result.Contains("7 x 2 $9.95"));
        }
    }
}
