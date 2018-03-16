using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityCodeFirst.Models
{
    public class BlogContext : DbContext    
    {

        public BlogContext()
            : base("defaultConnection")
        {

        }

        // indicamos el modelo al cual queremos hacer query

        public DbSet<BlogPost> BlogPosts { get; set;}

        public DbSet <Comentario> Comentarios { get; set; }
    }
}