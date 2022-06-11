using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalPrograII
{
    public class AgendaC : PacientesC
    {
        public string FechaCita { get; set; }
        public string HoraInicioCita { get; set; }
        public string HoraFinCita { get; set; }
    }
}