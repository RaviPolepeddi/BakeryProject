using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryProj;

namespace BakeryTestProject
{
    [TestClass]
    public class UnitTestBlueberryMuffin
    {
        [TestMethod]
        public void CalculateBlueberryMuffin()
        {
            var quantity = 14;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("MB11");
            var result = prod.Calculate(quantity);
            Assert.IsTrue(result.Contains("7 x 2 $9.95"));
        }

        [TestMethod]
        public void CalculateBlueberryMuffinOutput2()
        {
            var quantity = 14;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("MB11");
            var result = prod.Calculate(quantity);
            Assert.IsTrue(result.Contains("1 x 8 $24.95"));
        }

        [TestMethod]
        public void CalculateBlueberryMuffinwithIncorrectValue()
        {
            var quantity = 14;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("MB11");
            var result = prod.Calculate(quantity);
            Assert.IsFalse(result.Contains("1 x 3 $5.95"));
        }

        [TestMethod]
        public void CalculateBlueberryMuffinwithNull()
        {
            var quantity = 14;
            IProduct prod = null;
            BakeryProj.ProductFactory pfobj = new ProductFactory();
            prod = pfobj.GetProduct("MB11");
            var result = prod.Calculate(quantity);
            Assert.IsFalse(result.Contains(""));
        }
    }
}
