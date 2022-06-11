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
    public partial class SintomasPaciente : System.Web.UI.Page
    {
        static List<SintomasC> SintomasI = new List<SintomasC>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {

            SintomasC ingresoC = new SintomasC();
            ingresoC.CodigoSintoma = txtCodigoSintoma.Text;
            ingresoC.DescripcionSintoma = txtDescripcionSintoma.Text;

            SintomasI.Add(ingresoC);
            GuardarSintomas();

        }

        private void GuardarSintomas()
        {
            string json = JsonConvert.SerializeObject(SintomasI);

            string archivo = Server.MapPath("ListaSintomas.json");

            System.IO.File.WriteAllText(archivo, json);
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoSintoma.Text = " ";
            txtDescripcionSintoma.Text = " ";
        }
    }
}