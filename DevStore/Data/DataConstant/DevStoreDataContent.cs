using Data.Mapping;
using DevStore.Domain;
using System.Data.Entity;

namespace Data.DataConstant
{
    public class DevStoreDataContent : DbContext
    {

        public DevStoreDataContent(): base("DevStoreConnectionString")
        {
            Database.SetInitializer<DevStoreDataContent>(new DevStoreDataContextInitializer());
        }

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutosMap());
            modelBuilder.Configurations.Add(new CategoryMapping());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class DevStoreDataContextInitializer : DropCreateDatabaseIfModelChanges<DevStoreDataContent>
    { 
        protected override void Seed(DevStoreDataContent content)
        {
            content.Category.Add(new Category { Id = 1, Title = "Informatica" });
            content.Category.Add(new Category { Id = 2, Title = "Games" });
            content.Category.Add(new Category { Id = 3, Title = "Papelaria" });
            content.SaveChanges();

            content.Produtos.Add(new Produtos { Id = 1, CategoryId = 1, IsActive = true,  Title= "INFO 1"});
            content.Produtos.Add(new Produtos { Id = 2, CategoryId = 1, IsActive = true, Title = "INFO 2" });
            content.Produtos.Add(new Produtos { Id = 3, CategoryId = 1, IsActive = true, Title = "INFO 3" });
            content.Produtos.Add(new Produtos { Id = 4, CategoryId = 2, IsActive = true, Title = "INFO 4" });
            content.Produtos.Add(new Produtos { Id = 5, CategoryId = 2, IsActive = true, Title = "INFO 5" });
            content.Produtos.Add(new Produtos { Id = 6, CategoryId = 3, IsActive = true, Title = "INFO 6" });
            content.Produtos.Add(new Produtos { Id = 7, CategoryId = 3, IsActive = true, Title = "INFO 7" });
            content.SaveChanges();
            
        }
    }
}
