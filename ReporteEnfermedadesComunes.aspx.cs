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
    public partial class ReporteEnfermedadesComunes : System.Web.UI.Page
    {
        static List<HistorialPacienteC> enfermedadCH = new List<HistorialPacienteC>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Consultas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            enfermedadCH = JsonConvert.DeserializeObject<List<HistorialPacienteC>>(json);
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            enfermedadCH = enfermedadCH.OrderByDescending(a => a.DiagnosticoP ).ToList();
            GridView1.DataSource = enfermedadCH;
            GridView1.DataBind();
        }
    }
}