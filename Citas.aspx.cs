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
    public partial class Citas : System.Web.UI.Page
    {
       static List <AgendaC> citas = new List <AgendaC> ();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("agenda.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            citas = JsonConvert.DeserializeObject<List<AgendaC>>(json);
        }



        public void Guardar()
        {
            string json = JsonConvert.SerializeObject(citas);


            string archivo = Server.MapPath("agenda.json");


            System.IO.File.WriteAllText(archivo, json);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            DateTime cod = Calendar1.SelectedDate;
            string cod2 = TextBoxHI.Text;
            
            bool encontrar = false;

            foreach (var u in citas)
            {
                AgendaC horae = citas.Find(a => a.HoraInicioCita == cod2);
                AgendaC fechae = citas.Find(a => a.FechaCita == cod);

                if (fechae == null && horae == null)
                {
                    AgendaC cita = new AgendaC();
                    cita.NITPaciente = TextBoxnit.Text;
                    cita.FechaCita = Calendar1.SelectedDate;
                    cita.HoraInicioCita = TextBoxHI.Text;
                    cita.HoraFinCita = TextBoxHf.Text;
                    citas.Add (cita);
                    encontrar = true;

                }

                if (!encontrar)
                {
                    Response.Write("<script>alert('La cita ya existe, ingrese otra fecha u otra hora')</script>");
                  
                }


            }
 
        }
}
}