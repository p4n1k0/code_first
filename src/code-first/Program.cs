using code_first.Models;

namespace code_first
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new MarketContext();
            context.Database.EnsureCreated();
            context.Categories.Add(new Category { Name = "Drivers" });
            context.Products.Add(new Product { CategoryId = 1 });
            context.SaveChanges();
        }
    }
}
