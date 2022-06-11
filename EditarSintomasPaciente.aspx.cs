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
    public partial class EditarSintomasPaciente : System.Web.UI.Page
    {
        static List<SintomasC> SintomasI = new List<SintomasC>();
        static string sintomaas;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("ListaSintomas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            SintomasI = JsonConvert.DeserializeObject<List<SintomasC>>(json);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            sintomaas = txtCodigoSintomaE.Text;
            bool encontrar = false;

            foreach (var u in SintomasI)
            {
                SintomasC AlEditado = SintomasI.Find(c => c.CodigoSintoma == sintomaas);

                if (AlEditado != null)
                {
                    txtDescripcionSintomaE.Text = AlEditado.DescripcionSintoma;
                    encontrar = true;
                }
            }
            if (!encontrar)
            {
                Response.Write("<script>alert('El codigo de sintoma no se ha encotrado')</script>");
                sintomaas = "";
               txtCodigoSintomaE.Text = "";
                txtDescripcionSintomaE.Text = "";

            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (var u in SintomasI)
            {
                //en modificar se usa findIndex
                int editadoAdmin = SintomasI.FindIndex(c => c.CodigoSintoma == sintomaas);

                if (editadoAdmin > -1)
                {
                    SintomasI[editadoAdmin].CodigoSintoma = txtCodigoSintomaE.Text;
                    SintomasI[editadoAdmin].DescripcionSintoma =txtDescripcionSintomaE.Text;

                    GuardarEditadoS();
                    break;
                }

            }
        }
        protected void GuardarEditadoS()
        {
            string json = JsonConvert.SerializeObject(SintomasI);
            string archivo = Server.MapPath("ListaSintomas.json");
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}