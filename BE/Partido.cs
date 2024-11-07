using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Partido
    {
        public int IdPartido { get; set; } // PK
        public Deporte Deporte { get; set; } // Objeto de tipo Deporte en lugar de IdDeporte y Descripcion
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaPartido { get; set; }
        public int MarcadorLocal { get; set; }
        public int MarcadorVisitante { get; set; }

        public Partido()
        {
            // Inicializo los valores de marcador en 0 por defecto
            MarcadorLocal = 0;
            MarcadorVisitante = 0;
        }
    }
}
