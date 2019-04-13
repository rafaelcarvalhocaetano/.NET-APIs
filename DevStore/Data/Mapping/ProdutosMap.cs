using DevStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Data.Mapping
{
    public class ProdutosMap : EntityTypeConfiguration<Produtos>
    {
        public ProdutosMap()
        {
            ToTable("Produto");

            HasKey(x => x.Id);

            Property(x => x.Title).HasMaxLength(60).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.AcquireDate).IsRequired();


            HasRequired(x => x.Category);
            //HasMany(x => x.Category);
        }
    }
}
