using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator3
{
    public partial class DSH_CHANGE_IMG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //KOMENTET SHPJEGOJNE NJE KONCEPT PER AUTENTIFIKIMIN E NJE PERDORUESIII
            //if(!Tokens.Authorizations.Select(i => i.AuthorizationDescription.Contains("ChangeImng")).Any())
            //{
            //   //Response.Redirect()
            //}
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/img/download_new.png";

            //user ===user
            //if ( Session["User"]!=null && Session["user"].ToString().Equals("user"))
            //{

            //}
        }
    }
}