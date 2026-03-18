using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SEÇAO10HP.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        public UsedProduct() { }
        public UsedProduct(string name ,double price ,DateTime manufactureDate) : base(name , price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " | (USADO) "
                + " Total:$ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " | ( Data De Fabricação: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + " )";
        }
    }
}
