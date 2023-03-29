using Microsoft.AspNetCore.Mvc;
using MovieRentalAPI.Models;
using MovieRentalAPI.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net;

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

        public Customer UpdateCustomerById(int CustomerId, [FromBody] CustomerVM customer)
        {
            var _customer = _context.Customers.FirstOrDefault(c => c.Id == CustomerId);
            if(_customer != null)
            {
                _customer.FirstName = customer.FirstName;
                _customer.LastName = customer.LastName;
                _customer.Address = customer.Address;
                _customer.City = customer.City;
                _customer.Province = customer.Province;

                _context.SaveChanges();
            }

            return _customer;
        }

        public void DeleteCustomerById(int CustomerId)
        {
            var _customer = _context.Customers.FirstOrDefault(c => c.Id == CustomerId);
            if(_customer != null)
            {
                _context.Customers.Remove(_customer);
                _context.SaveChanges();
            }
        }
    }
}
