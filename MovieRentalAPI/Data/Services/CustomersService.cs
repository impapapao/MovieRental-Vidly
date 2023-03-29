using MovieRentalAPI.Models;
using MovieRentalAPI.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

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

        public List<Customer> GetAllCustomer()
        {
            var allCustomer = _context.Customers.ToList();
            return allCustomer;
        }

        public Customer GetCustomerById(int CustomerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == CustomerId);
            return customer;
        }
    }
}
