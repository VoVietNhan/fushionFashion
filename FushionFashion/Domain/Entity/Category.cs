using Domain.Base;
using Domain.Enum;

namespace Domain.Entity
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public EnumStatus Status { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
