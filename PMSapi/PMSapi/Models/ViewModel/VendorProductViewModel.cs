using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMSapi.Models.ViewModel
{
 
    public class VendorProductViewModel
    {
        public int VendorProductId { get; set; }
        public int ProductId { get; set; }
        public int Rate { get; set; }
        public int VendorId { get; set; }
        public string ImagePath { get; set; }
        public string ProductName { get; set; }
    
    }
}