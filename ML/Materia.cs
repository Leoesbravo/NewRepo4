using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    //Atributos
    public class Materia
    {
        //IdMateria,Nombre,Creditos,Costo
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public byte Creditos { get; set; } //{0,255}
        public decimal Costo { get; set; }
        public string FechaRegistro { get; set; }
        public List<object> Materias { get; set; }

        //Propiedad de navegación
        public Semestre Semestre { get; set; }
    }
}
