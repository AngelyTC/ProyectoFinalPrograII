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
    public partial class CrearConsulta : System.Web.UI.Page
    {
        static List<HistorialPacienteC> ingresoHistorial = new List<HistorialPacienteC>();
        static List<SintomasC> sintomasH = new List<SintomasC>();
        static List<MedicamentosC> medicamentosH = new List<MedicamentosC>();

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnIngresoConsulta_Click(object sender, EventArgs e)
        {
            HistorialPacienteC  ingresoH = new HistorialPacienteC();
            ingresoH.IdConsulta = txtIdConsulta.Text;
            ingresoH.NITPaciente = txtNITpaciente.Text;
            ingresoH.FechaHoraConsultas = txtFechaHora.SelectedDate;
            ingresoH.TemperaturaP=txtTemperatura.Text;
            ingresoH.PresionP = txtPresion.Text;
            ingresoH.sintomasPaciente = sintomasH.ToArray().ToList();
            ingresoH.DiagnosticoP = txtDiagnostico.Text;
            ingresoH.TratamientoP = txtTratamiento.Text;
            ingresoH.RecetaP = medicamentosH.ToArray().ToList();
            ingresoH.VistaProximaP = txtNextVisit.Text;
            ingresoH.CostoConsultaP = txtCosto.Text;
            string archivoOrigen = Path.GetFileName(FileUpload1.FileName);

            try
            {       
                FileUpload1.SaveAs(Server.MapPath("~/imagenes/") + archivoOrigen);
                Label1.Text = "Exitosamente Subido";
            }
         
            catch (Exception ex)
            {
                Label1.Text = "No se pudo subir, se generó el siguiente error:  " + ex.Message;
            }


            ingresoHistorial.Add(ingresoH);
            GuardarHistorialPaciente();
            medicamentosH.Clear();
            sintomasH.Clear();
         
        }

        private void GuardarHistorialPaciente()
        {
            string json = JsonConvert.SerializeObject(ingresoHistorial);

            string archivo = Server.MapPath("HistorialPaciente.json");

            System.IO.File.WriteAllText(archivo, json);
        }

        protected void btnIngresoReceta_Click(object sender, EventArgs e)
        {
            MedicamentosC  ingresoMedica = new MedicamentosC();
            ingresoMedica.Dosis = txtDosis.Text;
            ingresoMedica.horaAdministracion = txtHorasAdmin.Text;         

            medicamentosH.Add(ingresoMedica);
        }

        protected void btnIngreSintomas_Click(object sender, EventArgs e)
        {
            SintomasC ingreSintoma = new SintomasC();
            ingreSintoma.DescripcionSintoma = txtSintomas.Text;

            sintomasH.Add(ingreSintoma);
        }
    }
}