using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssisant.Models.ModelConfig
{
    public class ItemCategoryConfig : IEntityTypeConfiguration<ItemCategory>
    {
        public void Configure(EntityTypeBuilder<ItemCategory> builder)
        {
            builder.ToTable("M_categories");
            builder.HasKey(x => x.Id);

            //builder.Navigation(c => c.Items);
        }
    }
}
