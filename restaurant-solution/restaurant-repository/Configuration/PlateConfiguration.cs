using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using restaurant_domain;

namespace Restaurant.Repository.Configuration
{
    public class PlateConfiguration : IEntityTypeConfiguration<Plate>
    {
        public void Configure(EntityTypeBuilder<Plate> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
