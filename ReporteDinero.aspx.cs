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
    public partial class ReporteDinero : System.Web.UI.Page
    {
        List<HistorialPacienteC> Temp = new List<HistorialPacienteC>();
        protected void Page_Load(object sender, EventArgs e)
        {
            String archivo = Server.MapPath("Consultas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            Temp = JsonConvert.DeserializeObject<List<HistorialPacienteC>>(json);
        }

        protected void btnVisualizar_Click(object sender, EventArgs e)
        {
            int num1 = 0;

            foreach (var u in Temp)
            {

                num1 += Convert.ToInt32(u.CostoConsultaP);
                Label2.Text = num1.ToString();
                GridView1.DataSource = Temp;
                GridView1.DataBind();
            }
        }
    }
}