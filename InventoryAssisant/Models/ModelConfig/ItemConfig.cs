using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssisant.Models.ModelConfig
{
    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Id);

            builder.ToTable("M_Items");

            builder.HasOne<ItemCategory>(item => item.Category)
                .WithMany(category => category.Items)
                .HasForeignKey(item => item.CategoryId);

            builder.Property(i => i.Name).HasMaxLength(30).IsRequired();

            builder.Property(i => i.Price).HasPrecision(18,2);

            builder.Property(i=>i.Amount).IsRequired();

        }
    }
}
