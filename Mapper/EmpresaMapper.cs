using Entity;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class EmpresaMapper
    {
        public static EmpresaEntity Map(Empresa empresa)
        {
            {
                return new EmpresaEntity
                {
                    IdEmpresa = empresa.IdEmpresa,
                    Descripcion = empresa.Descripcion
                    
                };
        
            }
            
        }
        public static Empresa Map(EmpresaEntity empresaEntity)
        {
            {
                return new Empresa
                {
                    IdEmpresa = empresaEntity.IdEmpresa,
                    Descripcion = empresaEntity.Descripcion
                };
        
            }
            
        }



    }
}
