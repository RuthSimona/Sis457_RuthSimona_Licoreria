using CadLicoreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria
{
    public class ProductoCln
    {
        public static List<paProductosListar_Result> ListarPa(string parametro)
        {
            using (var context = new LabLicoreriaEntities())
            {
                return context.paProductosListar(parametro).ToList();
            }
        }
    }
}
