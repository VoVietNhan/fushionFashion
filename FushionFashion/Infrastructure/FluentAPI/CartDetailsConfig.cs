using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentAPI
{
    public class CartDetailsConfig : IEntityTypeConfiguration<CartDetails>
    {
        public void Configure(EntityTypeBuilder<CartDetails> builder)
        {
            builder.HasKey(k => new { k.CartId, k.ProductId });

            builder.Ignore(x => x.Id);

            builder.HasOne<Cart>(x => x.Cart)
                .WithMany(x => x.CartDetails)
                .HasForeignKey(x => x.CartId);

            builder.HasOne<Product>(x => x.Product)
                .WithMany(x => x.CartDetails)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
