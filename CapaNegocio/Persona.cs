using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Persona
    {
        // Declaración de atributos
        private string nombres;
        private string apellidos;
        private string dni;
        private string numeroTelefonico;
        private string expLaboral;
        private string correo;

        //Propiedades de lectura
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string NumeroTelefonico { get => numeroTelefonico; set => numeroTelefonico = value; }
        public string ExpLaboral { get => expLaboral; set => expLaboral = value; }
        public string Correo { get => correo; set => correo = value; }

    }
}
