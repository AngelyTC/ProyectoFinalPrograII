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
    public partial class CrearConsultaPaciente : System.Web.UI.Page
    {
        static List<HistorialPacienteC> ingresoHistorial = new List<HistorialPacienteC>();
        static List<SintomasC> sintomasH = new List<SintomasC>();
        static List<MedicamentosC> medicamentosH = new List<MedicamentosC>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresoConsulta_Click(object sender, EventArgs e)
        {
            HistorialPacienteC ingresoH = new HistorialPacienteC();
            ingresoH.IdConsulta = txtIdConsulta.Text;
            ingresoH.NITPaciente = txtNITpaciente.Text;
            ingresoH.FechaHoraConsultas = cldConsulta.SelectedDate;
            ingresoH.TemperaturaP = txtTemperatura.Text;
            ingresoH.PresionP = txtPresion.Text;
            ingresoH.SintomasPaciente = sintomasH.ToArray().ToList();
            ingresoH.DiagnosticoP = txtDiagnostico.Text;
            ingresoH.TratamientoP = txtTratamiento.Text;
            ingresoH.RecetaP = medicamentosH.ToArray().ToList();
            ingresoH.VistaProximaP = cldProximaVisita.SelectedDate;
            ingresoH.CostoConsultaP = txtCosto.Text;
            string archivoOrigen = Path.GetFileName(FileUpload1.FileName);

            try
            {
                FileUpload1.SaveAs(Server.MapPath(@"C: \Users\USUARIO\Desktop\imagenesProgra\descarga.jpg") + archivoOrigen);
                Label1.Text = "Exitosamente Subido";
            }

            catch (Exception ex)
            {
                Label1.Text = "No se pudo subir, se generó el siguiente error:  " + ex.Message;
            }

            string archivo = @"C: \Users\USUARIO\Desktop\imagenesProgra\descarga.jpg" + FileUpload1.FileName;
            ingresoH.imagenesP = archivo;

            ingresoHistorial.Add(ingresoH);
            GuardarHistorialPaciente();
            medicamentosH.Clear();
            sintomasH.Clear();
        }

        private void GuardarHistorialPaciente()
        {
            string json = JsonConvert.SerializeObject(ingresoHistorial);

            string archivo = Server.MapPath("Consultas.json");

            System.IO.File.WriteAllText(archivo, json);
        }

        protected void btnIngresoSintoma_Click(object sender, EventArgs e)
        {
            SintomasC ingreSintoma = new SintomasC();
            ingreSintoma.DescripcionSintoma = txtSintomas.Text;

            sintomasH.Add(ingreSintoma);
        }

        protected void btnIngresoReceta_Click(object sender, EventArgs e)
        {
            MedicamentosC ingresoMedica = new MedicamentosC();
            ingresoMedica.Dosis = txtDosis.Text;
            ingresoMedica.horaAdministracion = txtHorasAdmin.Text;

            medicamentosH.Add(ingresoMedica);
        }
    }
}