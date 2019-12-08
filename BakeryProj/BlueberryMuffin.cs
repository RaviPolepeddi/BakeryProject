using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryProj
{
   class BlueberryMuffin:IProduct
    {
       public Dictionary<int, double> ProdcodePack = new Dictionary<int, double>();
       public BlueberryMuffin()
       {
           Dictionary<int, double> codepack = new Dictionary<int, double>();
           codepack.Add(2, 9.95);
           codepack.Add(5, 16.95);
           codepack.Add(8, 24.95);
           ProdcodePack = codepack;
       }

        public List<string> Calculate(int quantity)
        {
            List<string> pricebreakup = new List<string>();

            if (quantity % 8 == 0)
            {
                pricebreakup.Add((quantity / 8).ToString() + " x 8" + " " + "$" + ProdcodePack[8].ToString());
                if (QuantityVerification((quantity / 8), 8, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if (quantity % 5 == 0)
            {
                pricebreakup.Add((quantity / 5).ToString() + " x 5" + " " + "$" + ProdcodePack[5].ToString());
                if (QuantityVerification((quantity / 5), 5, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if (quantity % 2 == 0)
            {
                pricebreakup.Add((quantity / 2).ToString() + " x 2" + " " + "$" + ProdcodePack[2].ToString());
                if (QuantityVerification((quantity / 2), 2, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            //if ((quantity % 8) == 3)
            //{
            //    pricebreakup.Add((quantity / 8).ToString() + " x 8  " + " " + "$" + ProdcodePack[8].ToString());
            //    pricebreakup.Add(((quantity % 8) / 3).ToString() + " x 3" + " " + "$" + ProdcodePack[3].ToString());

            //    var a = (quantity / 8) * 8;
            //    var b = ((quantity % 8) / 3) * 3;

            //    if (QuantityVerification((a+b), 0, quantity))
            //    {
            //        pricebreakup.Add("Or");
            //    }
            //}
            if ((quantity % 8) == 5)
            {
                pricebreakup.Add((quantity / 8).ToString() + " x 8" + " " + "$" + ProdcodePack[9].ToString());
                pricebreakup.Add(((quantity % 8) / 5).ToString() + " x 5" + " " + "$" + ProdcodePack[5].ToString());

                var a = (quantity / 8) * 8;
                var b = ((quantity % 8) / 5) * 5;

                if (QuantityVerification((a + b), 0, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if ((quantity % 5) == 2)
            {
                pricebreakup.Add((quantity / 5).ToString() + " x 5" + " " + "$" + ProdcodePack[5].ToString());
                pricebreakup.Add(((quantity % 5) / 2).ToString() + " x 2" + " " + "$" + ProdcodePack[2].ToString());

                var a = (quantity / 5) * 5;
                var b = ((quantity % 5) / 2) * 2;

                if (QuantityVerification((a + b), 0, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if ((quantity % 8) % 5 == 0)
            {
                pricebreakup.Add((quantity / 8).ToString() + " x 8" +" "+ "$" + ProdcodePack[8].ToString());
                pricebreakup.Add(((quantity % 8) / 5).ToString() + " x 5" + " " + "$" + ProdcodePack[5].ToString());

                var a = (quantity / 8) * 8;
                var b = ((quantity % 8) / 8) * 8;

                if (QuantityVerification((a + b), 0, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if ((quantity % 8) % 2 == 0)
            {
                pricebreakup.Add((quantity / 8).ToString() + " x 8" + " " + "$" + ProdcodePack[8].ToString());
                pricebreakup.Add(((quantity % 8) / 2).ToString() + " x 2" + " " + "$" + ProdcodePack[2].ToString());

                var a = (quantity / 8) * 8;
                var b = ((quantity % 8) / 2) * 2;

                if (QuantityVerification((a + b), 0, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            //else
            //{
            //    pricebreakup.Add("Please add the proper quantity as per the packs available");
            //}


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
