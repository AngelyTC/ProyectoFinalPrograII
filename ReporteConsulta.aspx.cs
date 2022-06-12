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
    public partial class ReporteConsulta : System.Web.UI.Page
    {
        static List<PacientesC> pacientes = new List<PacientesC>();
        static DateTime fecha1;
        static DateTime fecha2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                leer();
            }
        }

        protected void Buttongenerargrid_Click(object sender, EventArgs e)
        {
            double edad1, edad2;
            foreach (var i in pacientes)
            {
                if (TextBox1.Text == i.NITPaciente)
                {
                    fecha1 = Convert.ToDateTime(i.FechaNPaciente);
                }
                if (TextBox2.Text == i.NITPaciente)
                {
                    fecha2 = Convert.ToDateTime(i.FechaNPaciente);
                }
            }
            edad1 = edad(fecha1);
            edad2 = edad(fecha2);

            double promedio = (edad1 + edad2) / 2;
            Label1.Text = "la edad promedio de los pacientes es: " + promedio.ToString();
        }

        public double edad(DateTime FechaNacimiento)
        {
            double edad = DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;
            return (edad);
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/pacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacientes = JsonConvert.DeserializeObject<List<PacientesC>>(json);
        }
    }
}