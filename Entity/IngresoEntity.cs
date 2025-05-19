using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class IngresoEntity
    {
        private int idIngreso;
        private string codigoDeBarra;
        private string nombreInsumo;
        private string descripcion;
        private int idEmpresa;
        private EmpresaEntity empresa;
        private int cantidad;
        private string nombreEncargadoIngreso;
        private DateTime fechaRegistro;

        public int IdIngreso { get => idIngreso; set => idIngreso = value; }
        public string CodigoDeBarra { get => codigoDeBarra; set => codigoDeBarra = value; }
        public string NombreInsumo { get => nombreInsumo; set => nombreInsumo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public EmpresaEntity Empresa { get => empresa; set => empresa = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string NombreEncargadoIngreso { get => nombreEncargadoIngreso; set => nombreEncargadoIngreso = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
    }
}
