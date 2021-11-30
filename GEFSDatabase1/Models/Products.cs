using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GEFSDatabase1.Models
{
    
    public class Products
    {
        public int ProductID { get; set; }

        
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Price { get; set; }

        public int CategoryID { get; set; }
       
        public int Category { get; set; }
            
        public int SupplierID { get; set; }

        public int Supplier { get; set; }

        //public Category { get; set; }
    }
}
