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
        List<MedicamentosC> mediTemp = new List<MedicamentosC>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Medi.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            mediTemp = JsonConvert.DeserializeObject<List<MedicamentosC>>(json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
      
            foreach (var a in mediTemp)
            {
                MedicamentosC buscar = mediTemp.Find(c => c.CodigoMedicamento != null);
                               

                if (a.CodigoMedicamento != null)
                {
                    GridView1.DataSource = mediTemp;
                    GridView1.DataBind();
                }
            }

        }
    }
}