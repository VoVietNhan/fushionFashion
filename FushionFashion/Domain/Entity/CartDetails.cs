using Domain.Base;

namespace Domain.Entity
{
    public class CartDetails : BaseEntity
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public Guid CartId { get; set; }
        public Cart? Cart { get; set; }
    }
}
