using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityCodeFirst.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="VARCHAR")]
        [StringLength(200)]
        public string Titulo { get; set; }

        [Required]
        [Column(TypeName="VARCHAR")]
        [StringLength(1000)]
        public string Contenido { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public  string Autor { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Publicacion { get; set; }

        public List<Comentario> Comentarios { get; set; }

    }
}