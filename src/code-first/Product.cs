namespace code_first
{
    public sealed class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
