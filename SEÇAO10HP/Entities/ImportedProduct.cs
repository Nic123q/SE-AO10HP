using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SEÇAO10HP.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name , double price , double customsFee) : base(name , price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name 
                + " | Total:$ " 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + " | (Valor Do Frete: $ " 
                + CustomsFee.ToString("F2" , CultureInfo.InvariantCulture) 
                + ")" ;
        }
    }
}
