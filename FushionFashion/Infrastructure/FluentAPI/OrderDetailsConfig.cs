using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentAPI
{
    public class OrderDetailsConfig : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(k => new { k.OrderId, k.ProductId, k.SizeId });
            
            builder.Ignore(x => x.Id);

            builder.HasOne<Order>(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId);

            builder.HasOne<Product>(x => x.Product)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne<Size>(x => x.Size)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.SizeId);
        }
    }
}
