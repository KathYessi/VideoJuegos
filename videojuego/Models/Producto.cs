using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace videojuego.Models
{
    [Table("t_producto")]
        public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }
         [Column("Nombre")]
        public string Nombre{ get; set; }
         [Column("Categoria")]
        public string Categoria{ get; set; }
         [Column("Precio")]
        public int Precio{ get; set; }
        [Column("Descuento")]
        public int Descuento{ get; set; }

    }
}

    
