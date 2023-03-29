using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRentalAPI.Data.Services;
using MovieRentalAPI.Models.ViewModels;

namespace MovieRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public CustomersService _customersService;

        public CustomersController(CustomersService customersService)
        {
            _customersService = customersService;
        }


        [HttpGet("get-all-customer")]
        public IActionResult GetAllCustomer()
        {
            var allCustomer = _customersService.GetAllCustomer();
            return Ok(allCustomer);
        }

        [HttpGet("get-customer-by-id/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var Customer = _customersService.GetCustomerById(id);
            return Ok(Customer);
        }

        [HttpPost("add-customer")]
        public IActionResult AddCustomer([FromBody] CustomerVM customer)
        {
            _customersService.AddCustomer(customer);
            return Ok();
        }
    }
}
