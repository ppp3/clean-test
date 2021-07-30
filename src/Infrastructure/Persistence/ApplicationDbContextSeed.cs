using template.Domain.Entities;
using template.Domain.ValueObjects;
using template.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace template.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var administratorRole = new IdentityRole("Administrator");

            if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
            {
                await roleManager.CreateAsync(administratorRole);
            }

            var administrator = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.UserName != administrator.UserName))
            {
                await userManager.CreateAsync(administrator, "Administrator1!");
                await userManager.AddToRolesAsync(administrator, new [] { administratorRole.Name });
            }
        }

        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.TodoLists.Any())
            {
                context.TodoLists.Add(new TodoList
                {
                    Title = "Shopping",
                    Colour = Colour.Blue,
                    Items =
                    {
                        new TodoItem { Title = "Apples", Done = true },
                        new TodoItem { Title = "Milk", Done = true },
                        new TodoItem { Title = "Bread", Done = true },
                        new TodoItem { Title = "Toilet paper" },
                        new TodoItem { Title = "Pasta" },
                        new TodoItem { Title = "Tissues" },
                        new TodoItem { Title = "Tuna" },
                        new TodoItem { Title = "Water" }
                    }
                });


                await context.SaveChangesAsync();
            }

            //List<Customer> customers = new List<Customer>();
            //List<Book> books = new List<Book>();

            /*
            if (!context.Customers.Any())
            {
                customers.Add(new Customer { LastName = "Mueller", FirstName = "Lisa", City = "Essen", Postcode = 12345, Street = "Hausstr.", StreetNumber = "2" });
                customers.Add(new Customer { LastName = "Meier", FirstName = "Stefan", City = "Bochum", Postcode = 54321, Street = "Astr.", StreetNumber = "3a" });
                customers.Add(new Customer { LastName = "Heiler", FirstName = "Marcus", City = "Dortmund", Postcode = 54321, Street = "Bstr.", StreetNumber = "4" });
                foreach (var c in customers)
                {
                    context.Customers.Add(c);
                }

                await context.SaveChangesAsync();
            }
            */

            /*
            if (!context.Books.Any())
            {
                books.Add(new Book { Isbn = "4321324324", Author = "Ingrid Bergmann", Jahr = 2020, Titel = "C++ für Besoffene" });
                books.Add(new Book { Isbn = "11111111111", Author = "Ulrich Denzel", Jahr = 2014, Titel = "Java ist auch eine Insel" });
                books.Add(new Book { Isbn = "22222222222", Author = "Heinrich Alfons", Jahr = 2010, Titel = "C für Anfänger" });
                books.Add(new Book { Isbn = "22222222222", Author = "Heinrich Alfons", Jahr = 2010, Titel = "C für Anfänger" });

                foreach (var b in books)
                {
                    context.Add(b);
                }
                await context.SaveChangesAsync();
            }*/
            /*
            if (!context.Orders.Any())
            {
                context.Orders.Add(new Order { Customer = customers[0], });
                context.Orders.Add(new Order { Customer = customers[2],  });
                context.Orders.Add(new Order { Customer = new Customer { LastName = "Lauten", FirstName = "Heiner", City = "Hamburg", Postcode = 888888, Street = "Momsenstr.", StreetNumber = "12" },  } });
                await context.SaveChangesAsync();
            }*/
            /*
            if (!context.OrderBook.Any())
            {
                context.OrderBook.Add(new OrderBook { });
                await context.SaveChangesAsync();
            }*/
        }
    }
}
