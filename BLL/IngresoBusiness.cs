using DAL;
using Entity;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace BLL
{
    public class IngresoBusiness
    {
        private IngresoDAO ingresoDAO = new IngresoDAO();
        private EmpresaBusiness empresaBusiness = new EmpresaBusiness();


        public void GenerarIngreso(IngresoEntity ingreso)
        {
            try
            {
                using(var trx = new TransactionScope())
                {

                    if (ingreso.CodigoDeBarra == null)
                    {
                        throw new Exception("El codigo de barra no puede ser nulo");
                    }
                    if (ingreso.CodigoDeBarra.Length < 0 || ingreso.CodigoDeBarra.Length > 6)
                    {
                        throw new Exception("El codigo de barra debe tener 6 caracteres");
                    }
                    if (ingreso.NombreInsumo == null)
                    {
                        throw new Exception("El nombre del insumo no puede ser nulo");
                    }
                    if (ingreso.NombreInsumo.Length < 3)
                    {
                        throw new Exception("El nombre del insumo no puede tener menos de 3 caracteres");
                    }
                    if (ingreso.Descripcion == null)
                    {
                        throw new Exception("La descripcion no puede ser nula");
                    }
                    if(ingreso.Descripcion.Length < 5)
                    {
                        throw new Exception("La descripcion no puede tener menos de 5 caracteres");
                    }
                    if(empresaBusiness.GetAll().Where(c => c.IdEmpresa == ingreso.Empresa.IdEmpresa).ToList().Count == 0) 
                    {
                        throw new Exception("No se encontró ninguna empresa");
                    }
                    if(ingreso.Empresa == null)
                    {
                        throw new Exception("La empresa no puede ser nula");
                    }
                    if(ingreso.Cantidad <= 0)
                    {
                        throw new Exception("La cantidad no puede ser menor o igual a 0");
                    }
                    if(ingreso.NombreEncargadoIngreso == null)
                    {
                        throw new Exception("El nombre del encargado de ingreso no puede ser nulo");
                    }
                    if(ingreso.NombreEncargadoIngreso.Length < 4)
                    {
                        throw new Exception("El nombre del encargado de ingreso no puede tener mas de 4 caracteres");
                    }
                    
                    
                    ingreso.FechaRegistro= DateTime.Now;
                    ingresoDAO.GenerarIngreso(ingreso);
                    trx.Complete();

                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void ModificarIngreso(IngresoEntity ingreso)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                   
                    if (ingreso.Cantidad <= 0)
                    {
                        throw new Exception("La cantidad no puede ser menor o igual a 0");
                    }
                   
                    ingresoDAO.ModificarIngreso(ingreso);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }  
        public void EliminarIngreso(int idIngreso)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    ingresoDAO.EliminarIngreso(idIngreso);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<IngresoEntity> GetAll()
        {
            try
            {
                return ingresoDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void crearMultiplesAplicaciones(List<IngresoEntity> aplicaciones)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    foreach (IngresoEntity app in aplicaciones)
                    {
                        this.GenerarIngreso(app);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }






    }
}
