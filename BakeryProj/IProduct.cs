using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryProj
{
    public interface IProduct
    {
       // string ProductName { get; set; }
       // string ProductCode { get; set; }
      //  Dictionary<int,double> ProdcodePack { get; set; }
        List<string> Calculate(int quantity);
        
    }
}
