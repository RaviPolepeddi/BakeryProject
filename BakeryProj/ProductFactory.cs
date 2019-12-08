using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryProj
{
    public class ProductFactory
    {
        IProduct product = null;

        public IProduct GetProduct(string prodCode)
        {
            switch (prodCode)
            {
                case "VS5":
                    product = new VegimiteScroll();
                    break;
                case "MB11":
                    product = new BlueberryMuffin();
                    break;
                case "CF":
                    product = new Croissant();
                    break;
                default:
                    break;
            }
            return product;
        }


    }
}
