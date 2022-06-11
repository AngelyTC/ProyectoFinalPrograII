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
    public partial class Editar_Medicamentos : System.Web.UI.Page
    {
        string codigo;
        static List<MedicamentosC> medicamentosCs = new List<MedicamentosC>();
        static List<Editar_Medicamentos> editarmedi = new List<Editar_Medicamentos>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void CargarGridview()
        {
            GridView1.DataSource = null;
            GridView1.Refresh();
            GridView1.DataSource = resumen;
            GridView1.Refresh();
        }

        private void Leer()
        {
            string archivo2 = Server.MapPath("Medicamentos.json");
            StreamReader json1 = File.OpenText(archivo2);
            string json2 = json1.ReadToEnd();
            json1.Close();
            medicamentosCs = JsonConvert.DeserializeObject<List<MedicamentosC>>(json2);
        }

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(medicamentosCs);
            string archivo = Server.MapPath("Medicamentos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ButtonBuscarMedi_Click(object sender, EventArgs e)
        {
            codigo = TextBoxBuscarMedic.Text;
            bool encontrar = false;

            foreach (var u in medicamentosCs)
            {
                MedicamentosC editar = medicamentosCs.Find(c => c.CodigoMedicamento == codigo);

                if (editar != null)
                {
                    TextBoxIngreMedic.Text = editar.IngredienteGenerico;
                    TextBoxLabMedic.Text = editar.LaboratorioMarcaC;

                    encontrar = true;
                }
            }
            if (!encontrar)
            {
                Response.Write("<script>alert('El codigo de sintoma no se ha encotrado')</script>");
                codigo = "";
                TextBoxIngreMedic.Text = "";
                TextBoxLabMedic.Text = "";

            }
        }
    }
}