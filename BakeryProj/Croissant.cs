using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryProj
{
    class Croissant:IProduct
    {
        public Dictionary<int, double> ProdcodePack = new Dictionary<int, double>();

        public Croissant()
        {
            Dictionary<int, double> codepack = new Dictionary<int, double>();
            codepack.Add(3, 5.95);
            codepack.Add(5, 9.95);
            codepack.Add(9, 16.99);
            ProdcodePack = codepack;
        }

        public List<string> Calculate(int quantity)
        {
            List<string> pricebreakup = new List<string>();

            if (quantity % 9 == 0)
            {
                pricebreakup.Add((quantity / 9).ToString() + " x 9" + " " + "$" + ProdcodePack[9].ToString());
                if (QuantityVerification((quantity / 9), 9, quantity))
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
            if (quantity % 3 == 0)
            {
                pricebreakup.Add((quantity / 3).ToString() + " x 3" + " " + "$" + ProdcodePack[3].ToString());
                if (QuantityVerification((quantity / 3), 3, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if ((quantity % 9) == 3)
            {
                pricebreakup.Add((quantity / 9).ToString() + " x 9  " + " " + "$" + ProdcodePack[9].ToString());
                pricebreakup.Add(((quantity % 9) / 3).ToString() + " x 3" + " " + "$" + ProdcodePack[3].ToString());
                var a = (quantity / 9) * 9;
                var b = ((quantity % 9) / 3) * 3;

                if (QuantityVerification((a + b), 0, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if ((quantity % 9) == 5)
            {
                pricebreakup.Add((quantity / 9).ToString() + " x 9" + " " + "$" + ProdcodePack[9].ToString());
                pricebreakup.Add(((quantity % 9) / 5).ToString() + " x 5" + " " + "$" + ProdcodePack[5].ToString());
                var a = (quantity / 9) * 9;
                var b = ((quantity % 9) / 5) * 5;

                if (QuantityVerification((a + b), 0, quantity))
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
            if ((quantity % 9) % 5 == 0)
            {
                pricebreakup.Add((quantity / 9).ToString() + " x 9" + " " + "$" + ProdcodePack[9].ToString());
                pricebreakup.Add(((quantity % 9) / 5).ToString() + " x 5" + " " + "$" + ProdcodePack[5].ToString());
                var a = (quantity / 9) * 9;
                var b = ((quantity % 9) / 5) * 5;

                if (QuantityVerification((a + b), 0, quantity))
                {
                    pricebreakup.Add("Or");
                }
            }
            if ((quantity % 9) % 3 == 0)
            {
                pricebreakup.Add((quantity / 9).ToString() + " x 8" + " " + "$" + ProdcodePack[9].ToString());
                pricebreakup.Add(((quantity % 9) / 3).ToString() + " x 3" + " " + "$" + ProdcodePack[3].ToString());
                var a = (quantity / 9) * 9;
                var b = ((quantity % 9) / 3) * 3;

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
