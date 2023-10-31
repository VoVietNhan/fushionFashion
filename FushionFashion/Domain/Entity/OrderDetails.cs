using Domain.Base;

namespace Domain.Entity
{
    public class OrderDetails : BaseEntity
    {
        public int Quantity { get; set; }
        public Guid SizeId { get; set; }
        public Size? Size { get; set; }
        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
