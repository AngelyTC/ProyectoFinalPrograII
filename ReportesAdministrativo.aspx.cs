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
    public partial class ReportesAdministrativo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                leer();
            }
        }

        static List<AgendaC> citas = new List<AgendaC>();

        protected void btnReMasDias_Click(object sender, EventArgs e)
        {
            string dia = citas.Max(p => p.FechaCita);
            lbDiaMasPacientes.Text = dia;
        }

        protected void btnReEntre_Click(object sender, EventArgs e)
        {
            int contador = -1;

            citas = citas.OrderBy(f => f.FechaCita).ToList();

            for (int i = 0; i < citas.Count; i++)
            {
                if (txtFecha1.Text == citas[i].FechaCita)
                {
                    for (int j = i; j <= citas.Count; j++)
                    {
                        contador++;
                        lbEntre.Text = contador.ToString();
                        if (txtFecha2.Text == citas[i].FechaCita)
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void leer()
        {
            string archivo = Server.MapPath("~/agenda.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            citas = JsonConvert.DeserializeObject<List<AgendaC>>(json);
        }

        protected void btnReNoLLega_Click(object sender, EventArgs e)
        {
            lbSinPresentar.Text = "0";
        }
    }
}