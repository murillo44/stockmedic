using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Ingreso
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdIngreso { get; set; }
        [Required]
        public int IdEmpresa { get; set; }
        [Required]
        [StringLength(50)]
        public string CodigoDeBarra { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreInsumo { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]

        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        [Required]
        public int Cantidad { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreEncargadoIngreso { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }


    }
}
