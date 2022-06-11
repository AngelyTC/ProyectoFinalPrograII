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
    public partial class UpdatePaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                leer();
            }
        }

        static List<PacientesC> pacientes = new List<PacientesC>();
        static string paciente;

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            paciente = txtBuscar.Text;
            bool pacienteEncontrado = false;
            PacientesC pa = pacientes.Find(c => c.NITPaciente == paciente);
            if (pa != null)
            {
                txtNombre.Text = pa.NombrePaciente;
                TxtApellido.Text = pa.ApellidoPaciente;
                txtDireccion.Text = pa.DireccionPaciente;
                txtTelefono.Text = pa.TelefonoPaciente;
                btnActualizar.Enabled = true;
                pacienteEncontrado = true;
            }
            if (!pacienteEncontrado)
            {
                Response.Write("<script>alert('No se encotro al paciente')</script>");
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
            txtBuscar.Text = "";
            txtNombre.Text = "";
            TxtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int actualizarPaciente = pacientes.FindIndex(n => n.NITPaciente == paciente);
            if (actualizarPaciente > -1)
            {
                pacientes[actualizarPaciente].NombrePaciente = txtNombre.Text;
                pacientes[actualizarPaciente].ApellidoPaciente = TxtApellido.Text;
                pacientes[actualizarPaciente].DireccionPaciente = txtDireccion.Text;
                pacientes[actualizarPaciente].TelefonoPaciente = txtTelefono.Text;

                guardar();
                Response.Write("<script>alert('Paciente actualizado con exito!!')</script>");
                limpiarControles();
            }
        }
    }
}