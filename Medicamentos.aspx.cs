using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace ProyectoFinalPrograII
{
    public partial class Medicamentos : System.Web.UI.Page
    {
        static List<MedicamentosC> medicamentosCs = new List<MedicamentosC>();
        static List<ListadoEnfermedad> listadoenfermedades = new List<ListadoEnfermedad>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(medicamentosCs);
            string archivo = Server.MapPath("Medi.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ButtonIngresarEnfermedad_Click(object sender, EventArgs e)
        {
            ListadoEnfermedad listado = new ListadoEnfermedad();
            listado.Enfermedades = TextListMedi.Text;
            listadoenfermedades.Add(listado);
            Guardar();
        }

        protected void ButtonIngresogeneral_Click(object sender, EventArgs e)
        {
            MedicamentosC medicamentosC = new MedicamentosC();
            medicamentosC.CodigoMedicamento = TextCodigoMedi.Text;
            medicamentosC.IngredienteGenerico = TextIngredienteMedi.Text;
            medicamentosC.LaboratorioMarcaC = TextLabMedi.Text;
            medicamentosC.Enfermedad = listadoenfermedades.ToArray().ToList();
            medicamentosCs.Add(medicamentosC);
            Guardar();
        }
    }
}