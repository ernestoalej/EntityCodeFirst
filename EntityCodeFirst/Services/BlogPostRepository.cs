using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityCodeFirst.Models;

namespace EntityCodeFirst.Services
{
    public class BlogPostRepository
    {
        public List<BlogPost> ObtenerTodos()
        {
            using (var db = new BlogContext())
            {
                return db.BlogPosts.ToList();               
            }
        }

        internal void Crear(BlogPost model)
        {
            using (var db = new BlogContext())
            {
                db.BlogPosts.Add(model);
                db.SaveChanges();
            }
        }
    }
}