using Banco.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Datos
{
    public class Clientes
    {
        public List<Cliente> ListaClientes { get; set; } = new List<Cliente>();
        public Clientes()
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

            ListaClientes.Add(C1);
            ListaClientes.Add(C2);
            ListaClientes.Add(C3);

        }

        public Cliente ObtenerClientePorNombre(string nombre)
        {
            Cliente elegido = null;
            foreach (Cliente c in ListaClientes)
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
        public string Retirar(string nombre, decimal retiro)
        {
            Cliente c;
            string retirando = null;
            c = ObtenerClientePorNombre(nombre);
            if (c.Monto > retiro)
            {
                c.Monto = c.Monto - retiro;
            }
            else
            {
                retirando = "Saldo Insuficiente";
            }
            return retirando;
        }
        //SaldoTotal > La suma del monto de todos los clientes
        public decimal SaldoTotal(List<Cliente> lc)
        {
            decimal TotalBanco = 0;
            foreach (Cliente c in lc)
            {
                TotalBanco = TotalBanco + c.Monto;
            } 
            return TotalBanco;
        }
    }
}
