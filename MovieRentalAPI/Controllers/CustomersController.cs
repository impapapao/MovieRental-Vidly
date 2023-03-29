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

        [HttpPost("add-customer")]
        public IActionResult AddCustomer([FromBody] CustomerVM customer)
        {
            _customersService.AddCustomer(customer);
            return Ok();
        }
    }
}
