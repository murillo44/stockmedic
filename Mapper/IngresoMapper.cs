using Entity;
using Entity.Model;
using static System.Net.Mime.MediaTypeNames;

namespace Mapper
{
    public static class IngresoMapper
    {

        public static IngresoEntity Map(Ingreso ingreso)
        {
            try
            {
                return new IngresoEntity
                {
                    IdIngreso = ingreso.IdIngreso,
                    CodigoDeBarra = ingreso.CodigoDeBarra,
                    NombreInsumo = ingreso.NombreInsumo,
                    Descripcion = ingreso.Descripcion,
                    Empresa = EmpresaMapper.Map(ingreso.Empresa),
                    Cantidad = ingreso.Cantidad,
                    NombreEncargadoIngreso = ingreso.NombreEncargadoIngreso,
                    FechaRegistro = ingreso.FechaRegistro
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Ingreso Map(IngresoEntity ingresoEntity)
        {
            {
                return new Ingreso
                {
                    IdIngreso = ingresoEntity.IdIngreso,
                    CodigoDeBarra = ingresoEntity.CodigoDeBarra,
                    NombreInsumo = ingresoEntity.NombreInsumo,
                    Descripcion = ingresoEntity.Descripcion,
                    Empresa = EmpresaMapper.Map(ingresoEntity.Empresa),
                    Cantidad = ingresoEntity.Cantidad,
                    NombreEncargadoIngreso = ingresoEntity.NombreEncargadoIngreso,
                    FechaRegistro = ingresoEntity.FechaRegistro
                };
        
            }
            
        }









    }
}
