using ManejoFondo.Daos;
using ManejoFondo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Services
{
    public class DominioService
    {
        public List<FondoDominiosEntity> ConsultarDominios()
        {
            DominioDao dominioDao = new DominioDao();
            return dominioDao.ConsultarDominios();
        }
    }
}
