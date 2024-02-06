using HavenPharmacy.BL.Interfaces;
using HavenPharmacy.Models.Request;
using HavenPharmacy.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace HavenPharmacy.Controllers
{    
    [ApiController]
    [Route("api/pharmacy")]
    public class PharmacyController : ControllerBase
    {
        private readonly IPharmacyService _pharmacyService;

        public PharmacyController(IPharmacyService pharmacyService)
        {
            _pharmacyService = pharmacyService;
        }

        [HttpPost("add-product")]
        public ActionResult<AddProductResponse> AddProduct([FromBody] AddProductRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var response = _pharmacyService.AddProduct(request);
            return Ok(response);
        }

        [HttpPost("add-product-to-customer")]
        public ActionResult AddProductToCustomer([FromBody] AddProductToCustomerReuqest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            _pharmacyService.AddProductToCustomer(request);
            return NoContent();
        }

        [HttpGet("get-all-products")]
        public ActionResult<GetAllProductsResponse> GetAllProducts()
        {
            var response = _pharmacyService.GetAllProducts();

            return Ok(response);
        }
    }
}
