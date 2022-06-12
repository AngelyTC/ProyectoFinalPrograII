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
    public partial class TotalDinero : System.Web.UI.Page
    {
        List<HistorialPacienteC> pacienteTemp = new List<HistorialPacienteC>();
        static List<HistorialPacienteC> lista = new List<HistorialPacienteC>();
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
         
           
            foreach (var u in lista)
            {
                HistorialPacienteC mostrar = lista.Find(a => a.CostoConsultaP == a.CostoConsultaP);
                
                if (mostrar != null)
                {
                   
                }

            }
            
          

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}