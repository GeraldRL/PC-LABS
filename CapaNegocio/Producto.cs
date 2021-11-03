using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto
    {
        // Atributos
        private string nombre;
        private string logotipo;
        private string empresaFabricante;
        private string pais;
        private string etiqueta;
        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Logotipo { get => logotipo; set => logotipo = value; }
        public string EmpresaFabricante { get => empresaFabricante; set => empresaFabricante = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Etiqueta { get => etiqueta; set => etiqueta = value; }
        // Métodos
        public string Funcionar()
        {
            return "El método Funcionarrecién será implementado";
        }
        public string Garantizar()
        {
            return "El método Garantizar recién será implementado";
        }
        public string Beneficiar()
        {
            return "El método Beneficiar recién será implementado";
        }
    }
}
