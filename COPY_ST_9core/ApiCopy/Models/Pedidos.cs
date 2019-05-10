using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiCopy.Models
{
    [Table("PEDIDO")]
    public class Pedidos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_PEDIDO")]
        public int Id_Pedido { get; set; }
        [Column("PRODUCTO")]
        public String Producto { get; set; }
        [Column("CANTIDAD_PEDIDA")]
        public int Cantidad_Pedida { get; set; }
        [Column("FECHA")]
        public String Fecha { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_ARTICULOS")]
        public int Id_Articulos { get; set; }
      
    }
}