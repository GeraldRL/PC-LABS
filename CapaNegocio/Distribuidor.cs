using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Distribuidor : Persona
    {
        // Declaración atributo
        private string horasTrabajadas;
        // Propiedades de lectura y escritura
        public string HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
       
        // Declaración de métodos
        public string Distribuir()
        {
            return "El método Distribuir recién será implementado";
        }
        public string Representar()
        {
            return "El método Representar recién será implementado";
        }
        public string Comercializar()
        {
            return "El método Comercializar recién será implementado";
        }
        public string GanarExperiencia()
        {
            return "El método GanarExperiencia recién será implementado";
        }
        public string Coordinar()
        {
            return "El método Coordinar recién será implementado";
        }
    }
}
