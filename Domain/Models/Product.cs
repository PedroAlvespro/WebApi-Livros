
using WebApi_Livros.Domain.Helpers;

namespace WebApi_Livros.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public short QuantityPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
