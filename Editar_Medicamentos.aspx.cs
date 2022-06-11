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
            string archivo = Server.MapPath("Medicina.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            medicamentosCs = JsonConvert.DeserializeObject<List<MedicamentosC>>(json);
        }

        /*private void CargarGridview()
        {
            GridView1.DataSource = null;
            GridView1.Refresh();
            GridView1.DataSource = resumen;
            GridView1.Refresh();
        }*/

 

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(medicamentosCs);
            string archivo = Server.MapPath("Medicina.json");
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
                Response.Write("<script>alert('El codigo de medicamentos no existe')</script>");
                codigo = "";
                TextBoxIngreMedic.Text = "";
                TextBoxLabMedic.Text = "";

            }
        }

        protected void ButtonActualizarDatos_Click(object sender, EventArgs e)
        {
            foreach (var u in medicamentosCs)
            {
                //en modificar se usa findIndex
                int editadoAdmin = medicamentosCs.FindIndex(c => c.CodigoMedicamento == codigo);

                if (editadoAdmin > -1)
                {
                    medicamentosCs[editadoAdmin].IngredienteGenerico = TextBoxIngreMedic.Text;
                    medicamentosCs[editadoAdmin].LaboratorioMarcaC = TextBoxLabMedic.Text;

                    Guardar();
                    break;
                }

            }
        }
    }
}