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
    public partial class EliminarCita : System.Web.UI.Page
    {
        static List<AgendaC> citaTemp = new List<AgendaC>();
        string codigo = " ";
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("agenda.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            citaTemp = JsonConvert.DeserializeObject<List<AgendaC>>(json);
        }

        public void Guardar()
        {
            string json = JsonConvert.SerializeObject(citaTemp);


            string archivo = Server.MapPath("agenda.json");


            System.IO.File.WriteAllText(archivo, json);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            codigo = TextBox1.Text;
            bool encontrar = false;

            foreach (var u in citaTemp)
            {

                AgendaC cita = citaTemp.Find(a => a.FechaCita == codigo);

                if (cita != null)
                {
                    TextBox4.Text = cita.NITPaciente;
                    TextBox2.Text = cita.HoraInicioCita;
                    TextBox3.Text = cita.HoraFinCita;
                    encontrar = true;

                }
            }

            if (!encontrar)
            {
                Response.Write("<script>alert('El Producto no se encuentra')</script>");
          
               
                codigo = " ";
                TextBox1.Text = " ";
                

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (var u in citaTemp)
            {
                codigo = TextBox1.Text;
                citaTemp.RemoveAll(c => c.FechaCita == codigo);
                Response.Write("<script>alert('La cita fue borrada.')</script>");
                break;
            }
            Guardar();
        }
    }
}