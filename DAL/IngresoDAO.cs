using Entity;
using Entity.Model;
using Mapper;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class IngresoDAO
    {
        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }

        public void GenerarIngreso(IngresoEntity ingreso)
        {
            try
            {
                using (var appDbContext = getAppDbContext())
                {
                    Ingreso nuevoIngreso = IngresoMapper.Map(ingreso);
                    appDbContext.Ingresos.Add(nuevoIngreso);
                    appDbContext.Entry(nuevoIngreso.Empresa).State = EntityState.Unchanged;
                    appDbContext.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw;
            }

            
        }
        public void ModificarIngreso(IngresoEntity ingreso)
        {
            try
            {
                using (var appDbContext = getAppDbContext())
                {
                    Ingreso ingresoAModificar = appDbContext.Ingresos.Find(ingreso.IdIngreso);
                    
                    ingresoAModificar.Cantidad = ingreso.Cantidad;
                   
                    appDbContext.Entry(ingresoAModificar.Cantidad).State = EntityState.Unchanged;
               
                    appDbContext.SaveChanges();
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
                using (var appDbContext = getAppDbContext())
                {
                    Ingreso ingresoAEliminar = appDbContext.Ingresos.Find(idIngreso);
                    appDbContext.Ingresos.Remove(ingresoAEliminar);
                    appDbContext.SaveChanges();
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
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    return appDbContext.Ingresos.Include(a => a.Empresa).Select(a => IngresoMapper.Map(a)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }



    }
}
