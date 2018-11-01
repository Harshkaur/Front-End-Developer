using PMSapi.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using PMSapi.Models;
using System.Web.Http;
using System.Data.Entity;
using System.Web.Http.Cors;

namespace PMSapi.Controllers
{
    public class ProductController : ApiController
    {
        // Get all products specific to Vendor.
        [HttpGet]
        public IHttpActionResult GetAll(int id)
        {
           
            List<VendorProductViewModel> vendorProductViewModelObject = null;
            using (var pms = new PMSEntities())
            {
                var sfs = pms.VendorProducts.ToList();
                 vendorProductViewModelObject = pms.VendorProducts.Include(p=> p.Product).Where(v=> v.VendorId==id).Select(s => new VendorProductViewModel
                {
                    ProductId = s.ProductId,
                    Rate=s.Rate,
                    VendorId=s.VendorId,
                    VendorProductId=s.VendorProductId,
                    ImagePath=s.Product.ImagePath,
                    ProductName=s.Product.ProductName
                }).ToList();
            }
            return Ok(vendorProductViewModelObject);
        }
        //Get list of all Vednors
        [HttpGet]
        public IHttpActionResult GetVendors()
        {
            List<VendorViewModel> vendorViewModel = null;
            using (var pms = new PMSEntities())
            {
                vendorViewModel = pms.Vendors.Select(s => new VendorViewModel
                {
                    VendorId = s.VendorId,
                    Name = s.Name
                }).ToList();
            }
            return Ok(vendorViewModel);
        }
       
    }
}
