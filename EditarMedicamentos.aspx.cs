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

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(medicamentosCs);
            string archivo = Server.MapPath("Medi.json");
            System.IO.File.WriteAllText(archivo, json);
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

        protected void ButtonActualizarDatos_Click(object sender, EventArgs e)
        {
            codigo = TextCodMedi.Text;
           
            foreach (var u in medicamentosCs)
            {
                int editar = medicamentosCs.FindIndex(c => c.CodigoMedicamento == codigo);

                if (editar > -1)
                {
                    medicamentosCs[editar].IngredienteGenerico = TextIngreMedi.Text;
                    medicamentosCs[editar].LaboratorioMarcaC = TextLabMedi.Text;
                    Guardar();
                    Response.Write("<script>alert('El Producto fue editado')</script>");
                    break;
                    
                }
            }
        }
    }
}