using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpresaDAO
    {
        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }


        public EmpresaEntity GetById(int idempresa)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    return EmpresaMapper.Map(appDbContext.Empresas.Where(e => e.IdEmpresa == idempresa).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public List<EmpresaEntity> GetAll()
        {
            try
            {
                using (var appDbContext = getAppDbContext())
                {
                    return appDbContext.Empresas.Select(c => EmpresaMapper.Map(c)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
