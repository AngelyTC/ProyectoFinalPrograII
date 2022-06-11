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
        static List<Medicamentos_Listado> medicamentos_Listados = new List<Medicamentos_Listado>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonIngresoListadoMedi_Click(object sender, EventArgs e)
        {
            Medicamentos_Listado listadomedis = new Medicamentos_Listado();
            listadomedis.MedicamentosRecetas = TextBoxListadoMedi.Text;
            medicamentos_Listados.Add(listadomedis);
            Guardar();
        }

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(medicamentosCs);
            string archivo = Server.MapPath("Medicamentos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        private void Leer()
        {
            string archivo2 = Server.MapPath("Medicamentos.json");
            StreamReader json1 = File.OpenText(archivo2);
            string json2 = json1.ReadToEnd();
            json1.Close();
            medicamentosCs = JsonConvert.DeserializeObject<List<MedicamentosC>>(json2);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MedicamentosC medicamentos = new MedicamentosC();
            medicamentos.CodigoMedicamento = TextBoxCodigoMedi.Text;
            medicamentos.IngredienteGenerico = TextBoxIngreMedi.Text;
            medicamentos.LaboratorioMarcaC = TextBoxLabMedi.Text;
            medicamentos.enfermedades = medicamentos_Listados.ToArray().ToList();
            medicamentosCs.Add(medicamentos);

            Guardar();
        }
    }
}