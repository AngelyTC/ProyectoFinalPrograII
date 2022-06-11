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
    public partial class EditarMedicamentos : System.Web.UI.Page
    {
        static List<MedicamentosC> medicamentosCs = new List<MedicamentosC>();
        string codigo;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Medi.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            medicamentosCs = JsonConvert.DeserializeObject<List<MedicamentosC>>(json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            codigo = TextCodMedi.Text;
            bool encontrar = false;

            foreach (var u in medicamentosCs)
            {
                MedicamentosC editar = medicamentosCs.Find(c => c.CodigoMedicamento == codigo);

                if (editar != null)
                {
                    TextIngreMedi.Text = editar.IngredienteGenerico;
                    TextLabMedi.Text = editar.LaboratorioMarcaC;

                    encontrar = true;
                }
            }
            if (!encontrar)
            {
                Response.Write("<script>alert('El codigo de medicamentos no existe')</script>");
                codigo = "";
                TextIngreMedi.Text = "";
                TextLabMedi.Text = "";

            }
        }
    }
}