using Banco.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Datos
{
    public class BancoDatos
    {
        public string ObtenerFichaCliente(Cliente c)
        {
            string ficha = "Nombre: " + c.Nombre + "\n" +
                           "Saldo Actual: " + c.Monto + "\n";
            return ficha;
        }
    }
}
