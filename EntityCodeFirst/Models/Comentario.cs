using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityCodeFirst.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(150)]
        public string Contenido { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Autor { get; set; }

        public int BlogPostId { get; set; }
        [ForeignKey("BlogPostId")]
        public BlogPost blogPost { get; set; }


        
    }
}