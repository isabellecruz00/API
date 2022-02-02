using api_rest.Domain.Helpers;

namespace api_rest.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfPlatform UnitOfPlatform { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
