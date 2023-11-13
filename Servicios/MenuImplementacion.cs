using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaClientes.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {
            Console.WriteLine("Seleccion una Opcion");
            Console.WriteLine("0 -> Finalizar la Aplicacion");
            Console.WriteLine("1 -> Añadir un Nuevo usuario");
            int seleccionUsu = Convert.ToInt32(Console.ReadLine());
            return seleccionUsu;
            
        }
    }
}
