using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmpresaBusiness
    {

        private EmpresaDAO empresaDAO = new EmpresaDAO();

        public EmpresaEntity GetById(int idEmpresa)
        {
            try
            {
                return empresaDAO.GetById(idEmpresa);
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
                return empresaDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
