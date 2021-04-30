using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenMvcCoreAlexGM.Models
{
    [Table("coches")]
    public class Coche
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCOCHE")]
        public int IdCoche { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Conductor { get; set; }
        public string Imagen { get; set; }
    }
}
