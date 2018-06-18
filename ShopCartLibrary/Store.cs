using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public List<Movie> ListofMovies { get; set; }
        


        public Store()

        {
            ListofMovies = new List<Movie>();
        }
     
    }
}
