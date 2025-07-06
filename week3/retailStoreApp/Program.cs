using Microsoft.EntityFrameworkCore; 
using RetailStoreApp.Data;
using RetailStoreApp.Models;
using RetailStoreApp;

using var context = new AppDbContext();

// Step 1: Retrieve All Products
Console.WriteLine("All Products:");
var products = await context.Products.ToListAsync();
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

// Step 2: Retrieve a Product by ID (example: ID = 1)
Console.WriteLine("\nFind Product by ID (1):");
var product = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {product?.Name}");

// Step 3: Retrieve the First Expensive Product (Price > ₹50,000)
Console.WriteLine("\nFind First Expensive Product (Price > ₹50,000):");
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"Expensive: {expensive?.Name}");
