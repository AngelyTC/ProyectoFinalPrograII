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
    public partial class ReporteEnfermedadComun : System.Web.UI.Page
    {
        List<HistorialPacienteC> datoEnfermedad = new List<HistorialPacienteC>();
        List<comunEnfermedad> enfermedadComuns = new List<comunEnfermedad>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Consultas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            datoEnfermedad = JsonConvert.DeserializeObject<List<HistorialPacienteC>>(json);
        }



        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            datoEnfermedad = datoEnfermedad.OrderByDescending(a => a.DiagnosticoP).ToList();
           
            GridView1.DataSource = datoEnfermedad;
            GridView1.DataBind();

        }
    }
}