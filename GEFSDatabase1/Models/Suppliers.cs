using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GEFSDatabase1.Models
{

    public class Suppliers
    {
        public int SupplierID { get; set; }

        [Display(Name = "Name")] 
        public string Name { get; set; }


        public int ProductID { get; set; }

        public Products Products { get; set; }
        
    }
}
