using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace ProyectoFinalPrograII
{
    public partial class Citas : System.Web.UI.Page
    {
       static List <AgendaC> citas = new List <AgendaC> ();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Guardar()
        {
            string json = JsonConvert.SerializeObject(citas);


            string archivo = Server.MapPath("agenda.json");


            System.IO.File.WriteAllText(archivo, json);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AgendaC cita = new AgendaC ();
            cita.NITPaciente = TextBoxnit.Text;



        }
    }
}