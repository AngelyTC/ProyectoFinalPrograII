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
    public partial class ReporteMedicamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                leer();
            }
        }

        static List<MedicamentosC> medicamentosCs = new List<MedicamentosC>();

        protected void btnRepoMedicamento_Click(object sender, EventArgs e)
        {
            medicamentosCs = medicamentosCs.OrderByDescending(p => p.CodigoMedicamento).ToList();
            GridView1.DataSource = medicamentosCs;
            GridView1.DataBind();
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/Medi.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            medicamentosCs = JsonConvert.DeserializeObject<List<MedicamentosC>>(json);
        }
    }
}