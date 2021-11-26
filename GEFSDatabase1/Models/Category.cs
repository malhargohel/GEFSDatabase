using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEFSDatabase1.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string Name { get; set; }


        public string Location { get; set; }

        public ICollection<Products> Products { get; set; }


    }
}
