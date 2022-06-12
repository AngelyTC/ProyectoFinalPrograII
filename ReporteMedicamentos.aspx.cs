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
    public partial class ReporteMedicamentos : System.Web.UI.Page
    {
        List<HistorialPacienteC> mediTemp = new List<HistorialPacienteC>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Medi.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            mediTemp = JsonConvert.DeserializeObject<List<HistorialPacienteC>>(json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           

        }
    }
}