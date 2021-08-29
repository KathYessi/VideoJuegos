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
        public int Id { get; set; }
        public string Nombre  { get; set; }
        [Column("Nombre")]
        public string Categoria{ get; set; }
        [Column("Categoria")]
        public int Precio { get; set; }
        [Column("Precio")]
        public int Descuento { get; set; }
        [Column("Descuento")]     
        public string Gender { get; set; }

    }
}

    
