using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models.Mapper
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Id).IsRequired();
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.Price).IsRequired();
        }
    }
}
