namespace api_rest.Resources
{
    public class ProductResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityInPackage { get; set; }
        public string UnitOfPlatform { get; set; }
        public CategoryResource Category { get; set; }

    }
}
