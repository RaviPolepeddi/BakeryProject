using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryProj
{
    class VegimiteScroll:IProduct
    {
        public Dictionary<int, double> ProdcodePack = new Dictionary<int, double>();

        public VegimiteScroll()
        {
            Dictionary<int, double> codepack = new Dictionary<int, double>();
            codepack.Add(3, 6.99);
            codepack.Add(5, 8.99);
            ProdcodePack = codepack;

        }
       
        public List<string> Calculate(int quantity)
        {
            List<string> pricebreakup = new List<string>();

            if (quantity % 5 == 0)
            {
                pricebreakup.Add((quantity / 5).ToString() + " x 5" + " " + "$" + ProdcodePack[3].ToString());
                if (QuantityVerification((quantity / 5), 5, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if (quantity % 3 == 0)
            {
                pricebreakup.Add((quantity / 3).ToString() + " x 3" + " " + "$" + ProdcodePack[3].ToString());
                if (QuantityVerification((quantity / 3), 3, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if ((quantity % 5) == 3)
            {
                pricebreakup.Add((quantity / 5).ToString() + " x 5" + " " + "$" + ProdcodePack[5].ToString());
                pricebreakup.Add(((quantity % 5) / 3).ToString() + " x 3" + " " + "$" + ProdcodePack[3].ToString());
                var a = (quantity / 5) * 5;
                var b = ((quantity % 5) / 3) * 3;

                if (QuantityVerification((a + b), 0, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            return pricebreakup;
        }

        private bool QuantityVerification(int p, int p_2, int quantity)
        {
            bool res = false;
            if (p_2 != 0)
            {
                if (p * p_2 == quantity)
                    res = true;
            }
            else
            {
                if (p == quantity)
                {
                    res = true;
                }

            }
            return res;
        }
    }
}
