using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalPrograII
{
    public class HistorialPacienteC : AgendaC 
    {
        public string IdConsulta { get; set; }
        public DateTime FechaHoraConsulta { get; set; }
        public string TemperaturaP { get; set; }
        public string PresionP { get; set; }
        public string CodigoMedicamento { get; set; }
        public List<SintomasC> sintomasPaciente{ get; set; }
        public string DiagnosticoP { get; set; }
        public string TratamientoP { get; set; }
        public string RecetaP { get; set; }
        public string VistaProximaP { get; set; }
        public string CostoConsultaP { get; set; }
        public string imagenesP { get; set; }
    }
}