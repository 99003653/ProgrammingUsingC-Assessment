using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        public double TotalBillValue { get; set; }
        public Dictionary<int, double> GourmetOrganicshop(int ICode, string IName, Dictionary<int, double> price)
        {
            return price;
        }
        public double PayPerWeight(int weight)
        {
            
            return 1;
        }
        public double PayPerPiece(int quantity)
        {
            return 1;
        }
        public int TaxOnTotalBill()

        {
            return 1;
        }
    }
}
