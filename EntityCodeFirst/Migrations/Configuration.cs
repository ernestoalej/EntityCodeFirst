namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityCodeFirst.Models.BlogContext>
    {
        public Configuration()
        {       
            // para esta practica estará en true. 
            AutomaticMigrationsEnabled = true;

            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EntityCodeFirst.Models.BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. 

            context.Comentarios.AddOrUpdate(x => x.Id, new Models.Comentario()
            {
                Id = 1,
                Autor = "Virginia",
                BlogPostId = 1,
                Contenido = "Hola encantan tus videos"

            });
        }

    }
}
