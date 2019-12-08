using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryProj;

namespace BakeryTestProject
{
    [TestClass]
    public class UnitTestCroissant
    {
        [TestMethod]
        public void calculate_crossaint()
        {
            var quantity = 13;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("CF");
            var result = prod.Calculate(quantity);
            Assert.IsTrue(result.Contains("1 x 3 $5.95"));
        }

        [TestMethod]
        public void calculate_crossaintoutput2()
        {
            var quantity = 13;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("CF");
            var result = prod.Calculate(quantity);
            Assert.IsTrue(result.Contains("2 x 5 $9.95"));
        }

        [TestMethod]
        public void calculate_crossaintWithIncorrectOutput()
        {
            var quantity = 13;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("CF");
            var result = prod.Calculate(quantity);
            Assert.IsFalse(result.Contains("3 x 5 $9.95"));
        }

        [TestMethod]
        public void calculate_crossaintWithNullInputput()
        {
            var quantity = 0;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("CF");
            var result = prod.Calculate(quantity);
            Assert.IsFalse(result.Contains(""));
        }
    }
}
