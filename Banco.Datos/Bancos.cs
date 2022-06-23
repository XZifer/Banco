using Banco.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Datos
{
    public class Bancos
    {
        public List<Cliente> CuentaHabientes { get; set; } = new List<Cliente>();
        public Bancos()
        {
            Cliente C1 = new()
            {
                Nombre = "Jose",
                Monto = 0

            };
            Cliente C2 = new()
            {
                Nombre = "Arturo",
                Monto = 5000
            };
            Cliente C3 = new()
            {
                Nombre = "Debora",
                Monto = 63575
            };

            CuentaHabientes.Add(C1);
            CuentaHabientes.Add(C2);
            CuentaHabientes.Add(C3);

        }
        public Cliente ObtenerClientePorNombre(string nombre)
        {
            Cliente elegido = null;
            foreach (Cliente c in CuentaHabientes)
            {
                if (c.Nombre == nombre)
                {
                    elegido = c;
                }
            }
            return elegido;
        }
        public decimal Depositar(string nombre, decimal deposito)
        {
            Cliente c;
            c = ObtenerClientePorNombre(nombre);
            c.Monto = c.Monto + deposito;
            return c.Monto;
        }
    }
}
