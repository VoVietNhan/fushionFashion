using Domain.Base;
using Domain.Enum;

namespace Domain.Entity
{
    public class Account : BaseEntity
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public EnumStatus Status { get; set; }
        public EnumRole Role { get; set; }
        public Cart? Cart { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
