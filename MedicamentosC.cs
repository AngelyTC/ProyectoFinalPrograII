using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalPrograII
{
    public class MedicamentosC
    {
        public string CodigoMedicamento { get; set; }
        public string IngredienteGenerico { get; set; }
        public string LaboratorioMarcaC { get; set; }
        public List<ListadoEnfermedad> Enfermedad { get; set; }
        public string Dosis { get; set; }
        public string horaAdministracion { get; set; }
    }
}