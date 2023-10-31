using Domain.Base;
using Domain.Enum;

namespace Domain.Entity
{
    public class Cart : BaseEntity
    {
        public EnumStatus Status { get; set; }
        public ICollection<CartDetails> CartDetails { get; set; } = new List<CartDetails>();
    }
}
