using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Threading;

namespace AutoAgenciaCR_WebSite
{
    public partial class index : System.Web.UI.Page
    {

        private App_Code.UI.UIPrincipal p;

        protected void Page_Load(object sender, EventArgs e)
        {

            p = new App_Code.UI.UIPrincipal();

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            String usuario = txtUsuarioLogin.Text;
            String password = txtPasswordLogin.Text;
            //si los textbox no estan vacios se procesa la peticion
            if (usuario != "" || password != "")
            {
                bool condition = p.ValidarLogin(usuario, password);
                if (condition)
                {
                    //si pudo encontrar el usuario y contraseña en la bd

                }
                else
                {
                    //lblInfoLogin.Text = "Datos invalidos";
                    //ModalPopupExtender1.Show();
                }
            }
            else
            {
                //lblInfoLogin.Text = "Digite los datos";
                //ModalPopupExtender1.Show();
            }
        }
    }
}