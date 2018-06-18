using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartLibrary
{
    public class Movie
    {
        public string Title { get; set; }
        public string Discription { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal BuyingPrice { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} - ${1}", Title, SellingPrice);
            }
        }
    }
}
