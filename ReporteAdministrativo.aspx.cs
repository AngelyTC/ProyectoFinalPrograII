using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalPrograII
{
    public partial class ReporteAdministrativo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                leer();
            }
        }

        List<AgendaC> citas = new List<AgendaC>();

        protected void btnDiaPacientes_Click(object sender, EventArgs e)
        {
            string dia;
            dia = citas.Max(f => f.FechaCita);
            lbDiaMasPacientes.Text = dia;
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/agenda.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            citas = JsonConvert.DeserializeObject<List<AgendaC>>(json);
        }

        protected void btnDosFechas_Click(object sender, EventArgs e)
        {
            String fecha1, fecha2;
            fecha1 = txtFecha1.Text;
            fecha2 = txtFecha2.Text;
        }
    }
}