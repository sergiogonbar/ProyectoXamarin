using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APICopyCore.Models
{
    [Table("USUARIOS")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("PASSWORD")]
        public String Password { get; set; }
        [Column("FUNCION")]
        public String Funcion { get; set; }
        [Column("MAIL")]
        public String Mail { get; set; }
        [Column("TELEFONO")]
        public int Telf { get; set; }
    }

}
