using Domain.Base;

namespace Domain.Entity
{
    public class Size : BaseEntity
    {
        public string? ProSize { get; set; }
        public ICollection<ProductInfo> ProductInfos { get; set; } = new List<ProductInfo>();
        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
