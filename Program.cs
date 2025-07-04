using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RetailInventory
{
    class Program
    {
        static void Main()
        {
            using var context = new InventoryContext();

            if (!context.Categories.Any())
            {
                var electronics = new Category { Name = "Electronics" };
                var grocery = new Category { Name = "Grocery" };

                context.Categories.AddRange(electronics, grocery);

                context.Products.Add(new Product { Name = "Laptop", Price = 50000, Stock = 10, Category = electronics });
                context.Products.Add(new Product { Name = "Bread", Price = 50, Stock = 100, Category = grocery });

                context.SaveChanges();
            }

            var products = context.Products.Include(p => p.Category).ToList();

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - {p.Price} - {p.Stock} units - Category: {p.Category.Name}");
            }
        }
    }
}
