using Domain.Base;
using Domain.Enum;

namespace Domain.Entity
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public EnumStatus Status { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<ProductInfo> ProductInfos { get; set; } = new List<ProductInfo>();
        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
        public ICollection<CartDetails> CartDetails { get; set; } = new List<CartDetails>();
    }
}
