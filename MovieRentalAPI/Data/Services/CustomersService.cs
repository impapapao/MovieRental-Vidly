using MovieRentalAPI.Models;
using MovieRentalAPI.Models.ViewModels;

namespace MovieRentalAPI.Data.Services
{
    public class CustomersService
    {
        public AppDBContext _context;

        public CustomersService(AppDBContext context)
        {
            _context = context;
        }

        public void AddCustomer(CustomerVM customer)
        {
            var _customer = new Customer()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Address = customer.Address,
                City = customer.City,
                Province = customer.Province
            };
            _context.Customers.Add(_customer);
            _context.SaveChanges();
        }
    }
}
