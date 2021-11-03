using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Compradores : Persona
    {
        // Atributos
        private string ubicacion;
        private string antecedentes;
        // Propiedades
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Antecedentes { get => antecedentes; set => antecedentes = value; }

        // Métodos
        public string Organizar()
        {
            return "El método Organizar recién será implementado";
        }
        public string RevenderProductos()
        {
            return "El método RevenderProductos recién será implementado";
        }
        public string Ordenar()
        {
            return "El método Ordenar recién será implementado";
        }
        public string Promocionar()
        {
            return "El método Promocionar recién será implementado";
        }
        public string OfrecerProducto()
        {
            return "El método OfrecerProducto recién será implementado";
        }
    }
}
