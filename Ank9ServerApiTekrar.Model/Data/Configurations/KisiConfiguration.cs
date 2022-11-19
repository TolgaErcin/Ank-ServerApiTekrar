using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9ServerApiTekrar.Model.Data.Configurations
{
    public class KisiConfiguration : IEntityTypeConfiguration<Kisi>
    {
        public void Configure(EntityTypeBuilder<Kisi> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseIdentityColumn(1000,2);
            builder.Property(x => x.Tc).IsRequired().HasMaxLength(5);
            builder.Property(x => x.Ad).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Soyad).IsRequired().HasMaxLength(20);
            builder.Property(x => x.cinsiyet).IsRequired().HasConversion(new EnumToStringConverter<Cinsiyet>());
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Ad).IsUnique();
        }
    }
}
