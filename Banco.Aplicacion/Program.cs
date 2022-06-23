using Banco.Datos;
using Banco.Modelos.Clases;

namespace Banco.Aplicacion
{
    public class Program
    {
        public static void Main()
        {
            //Mensaje de Bienvenida
            Console.WriteLine("Bienvenido a su banco");
            //Identificarse
            SeleccionarCliente();
            //Saldo Total del Banco
            ;

        }

        

        private static void SeleccionarCliente()
        {
            //Selecciona un cliente
            Cliente ClienteSeleccionado = null;
            Clientes clientes = new Clientes();

            while (ClienteSeleccionado == null)
            {
                Console.WriteLine("Ingrese su nombre:");
                string ClienteElegido = Console.ReadLine();
                switch (ClienteElegido)
                {
                    case "Jose":
                        ClienteSeleccionado = clientes.ObtenerClientePorNombre(ClienteElegido);
                        break;
                    case "Arturo":
                        ClienteSeleccionado = clientes.ObtenerClientePorNombre(ClienteElegido);
                        break;
                    case "Debora":
                        ClienteSeleccionado = clientes.ObtenerClientePorNombre(ClienteElegido);
                        break;
                    default:
                        ClienteSeleccionado = null;
                        Console.WriteLine("Cliente no encontrado");
                        break;
                }

            }
            //Mostrar cliente
            BancoDatos banco = new BancoDatos();
            Console.WriteLine(banco.ObtenerFichaCliente(ClienteSeleccionado));
            //Preguntar si quiere hacer alguna operacion 
            string operacion = null;
            string retiro;
            while (operacion == null)
            {
                Console.WriteLine("Desea : R-Retirar D-Depositar S-Salir");
                operacion = Console.ReadLine();
                //Verificar operacion y realizar
                switch(operacion.ToUpper())
                {
                    case "R":
                        Console.Write("Cuanto deseas Retirar: $");
                        retiro = Console.ReadLine();
                        string retiraste = clientes.Retirar(ClienteSeleccionado.Nombre, decimal.Parse(retiro));
                        Console.WriteLine(retiraste + "\n" + banco.ObtenerFichaCliente(ClienteSeleccionado));
                        break;
                    case "D":
                        Console.Write("Cuanto deseas Depositar: $");
                        retiro = Console.ReadLine();
                        clientes.Depositar(ClienteSeleccionado.Nombre, decimal.Parse(retiro));
                        Console.WriteLine(banco.ObtenerFichaCliente(ClienteSeleccionado));
                        break;
                    case "S":
                        break;
                    default:
                        operacion = null;
                        break;

                }                
            }
            //Mostrar Saldo final del Banco
            decimal saldobanco = clientes.SaldoTotal(clientes.ListaClientes);
            Console.WriteLine("El saldo del Banco es: ${0}",saldobanco);
        }
    }
}
