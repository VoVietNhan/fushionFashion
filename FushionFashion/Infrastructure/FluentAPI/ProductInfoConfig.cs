using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentAPI
{
    public class ProductInfoConfig : IEntityTypeConfiguration<ProductInfo>
    {
        public void Configure(EntityTypeBuilder<ProductInfo> builder)
        {
            builder.HasKey(k => new { k.SizeId, k.ProductId });

            builder.Ignore(x => x.Id);

            builder.HasOne<Size>(x => x.Size)
                .WithMany(x => x.ProductInfos)
                .HasForeignKey(x => x.SizeId);

            builder.HasOne<Product>(x => x.Product)
                .WithMany(x => x.ProductInfos)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
