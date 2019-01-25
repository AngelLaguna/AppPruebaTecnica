using AppPruebaTecnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPruebaTecnica.Controller
{
    class EstadosController
    {

        public bool AddEstado(Estados estado)
        {
            try
            {
                CurpGeneralEntities entidad = new CurpGeneralEntities();
                entidad.Estados.Add(estado);
                entidad.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
