using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MovieRentalAPI.Models;
using System.Linq;

namespace MovieRentalAPI.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                if(!context.Movies.Any())
                {
                    context.Movies.AddRange(new Movie()
                    {
                        MovieTitle = "Thor",
                        MovieDescription = "Movie of God of Thunder",
                        Genre = "Action Fantasy"
                    },
                    new Movie()
                    {
                        MovieTitle = "Captain America",
                        MovieDescription = "Movie of Captain America",
                        Genre = "Action Fantasy"
                    });

                    context.SaveChanges();
                }

                if(!context.Customers.Any())
                {
                    context.Customers.AddRange(new Customer()
                    {
                        FirstName = "John",
                        LastName = "Smith",
                        Address = "3915 Hamill Avenue",
                        City = "San Diego",
                        Province = "California",
                    },
                    new Customer
                    {
                        FirstName = "Amelie",
                        LastName = "Lester",
                        Address = "555 Hinkle Deegan Lake Road",
                        City = "Binghamton",
                        Province = "New York"
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
