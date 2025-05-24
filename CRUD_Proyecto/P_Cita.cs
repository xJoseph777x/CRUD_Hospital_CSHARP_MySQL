using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Proyecto
{
    internal class P_Cita
    {
        public DateTime FechaCita { get; set; }
        public string HoraCita { get; set; } 
        public string Motivo { get; set; }
        public int Paciente_idPaciente { get; set; }
        public int Medico_idMedico { get; set; }
        public int IdCitas { get; set; } 
    }
}
