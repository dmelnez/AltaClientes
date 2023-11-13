using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaClientes.Dtos
{
    internal class ClientesDtos
    {

        string nombreCliente;

        string apellidoCliente;

        string dniCliente;

        DateOnly fechaNacimientoCliente;

        string emailCliente;

        int tlfCliente;

        DateOnly fechaAltaCliente;

        DateOnly fechaBajaCliente;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public DateOnly FechaNacimientoCliente { get => fechaNacimientoCliente; set => fechaNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public DateOnly FechaAltaCliente { get => fechaAltaCliente; set => fechaAltaCliente = value; }
        public DateOnly FechaBajaCliente { get => fechaBajaCliente; set => fechaBajaCliente = value; }
    }
}
