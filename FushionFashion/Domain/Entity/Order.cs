using Domain.Base;
using Domain.Enum;

namespace Domain.Entity
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public EnumStatus Status { get; set; }
        public Account? Account { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
