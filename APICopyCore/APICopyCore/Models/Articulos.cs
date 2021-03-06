﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APICopyCore.Models
{
    [Table("ARTICULOS")]
    public class Articulos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID_ARTICULOS")]
        public int Id_Articulos { get; set; }
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("CANTIDAD_STOCK")]
        public int Cantidad { get; set; }
        [Column("PRECIO_UNIDAD")]
        public int Precio { get; set; }
        [Column("TIPO")]
        public String Tipo { get; set; }
        [Column("IMAGEN")]
        public String Imagen { get; set; }
        [Column("MARCA")]
        public String Marca { get; set; }
        [Column("DESCRIPCION")]
        public String Descripcion { get; set; }

    }
}
