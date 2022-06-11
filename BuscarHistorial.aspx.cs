using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace ProyectoFinalPrograII
{
    public partial class BuscarHistorial : System.Web.UI.Page
    {
        List<HistorialPacienteC> paciente = new List<HistorialPacienteC>();
        List<HistorialPacienteC> pacienteTemp = new List<HistorialPacienteC>();
        string codigo;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Consultas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacienteTemp = JsonConvert.DeserializeObject<List<HistorialPacienteC>>(json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            codigo = TextBox1.Text;
            bool encontrar = false;

            foreach (var u in pacienteTemp)
            {

                HistorialPacienteC buscarp = pacienteTemp.Find(a => a.NITPaciente == codigo);

                if (buscarp != null)
                {
                    paciente.Add(buscarp);
                    GridView1.DataSource = paciente;
                    GridView1.DataBind();
                    encontrar = true;
                    break;
                }
            }

            if (!encontrar)
            {
                Response.Write("<script>alert('El paciente no tiene historial.')</script>");


                codigo = " ";
                TextBox1.Text = " ";


            }
        }
    }
}