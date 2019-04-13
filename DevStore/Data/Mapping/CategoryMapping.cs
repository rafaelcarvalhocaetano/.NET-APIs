using DevStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Data.Mapping
{
    public class CategoryMapping : EntityTypeConfiguration<Category>

    {
        public CategoryMapping()
        {
            ToTable("Categoria");

            HasKey(x => x.Id);

            Property(x => x.Title).HasMaxLength(60).IsRequired();
        }

    }
}
