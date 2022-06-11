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
    public partial class Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                leer();
            }
        }

        static List<PacientesC> pacientes = new List<PacientesC>();

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            PacientesC pacienteTemp = new PacientesC();
            pacienteTemp.NITPaciente = txtNit.Text;
            pacienteTemp.NombrePaciente = txtNombre.Text;
            pacienteTemp.ApellidoPaciente = TxtApellido.Text;
            pacienteTemp.DireccionPaciente = txtDireccion.Text;
            pacienteTemp.FechaNPaciente = CalendarNacimiento.SelectedDate.ToString();
            pacienteTemp.TelefonoPaciente = txtTelefono.Text;

            int pocicionPaciente = pacientes.FindIndex(n => n.NITPaciente == pacienteTemp.NITPaciente);
            if (pocicionPaciente == -1)
            {
                pacientes.Add(pacienteTemp);
                guardar();
                Response.Write("<script>alert('Cliente agregado con exito.')</script>");
                limpiarControles();
            }
            else
            {
                Response.Write("<script>alert('Cliente ya existente.')</script>");
                limpiarControles();
            }
        }

        private void guardar()
        {
            string archivo = Server.MapPath("~/pacientes.json");
            string json = JsonConvert.SerializeObject(pacientes);
            System.IO.File.WriteAllText(archivo, json);
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/pacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacientes = JsonConvert.DeserializeObject<List<PacientesC>>(json);
        }

        private void limpiarControles()
        {
            txtNit.Text = "";
            txtNombre.Text = "";
            TxtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
    }
}