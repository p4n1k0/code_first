namespace code_first
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var context = new MarketContext();
            context.Database.EnsureCreated();
            context.Categories.Add(new Category() { Name = "Drivers" });
            context.Products.Add(new Product() { CategoryId = 1, Name = "SSD Kingston" });
            context.SaveChanges();
        }
    }
}
