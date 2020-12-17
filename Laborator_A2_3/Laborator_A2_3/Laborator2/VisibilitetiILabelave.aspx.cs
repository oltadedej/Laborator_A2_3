using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator2
{
    public partial class VisibilitetiILabelave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Afisho_Fsheh(object sender, EventArgs e)
        {
            if (Label1.Visible) // e njejte me Label1.Visible ==true
            {
                Label1.Visible = false;

            }

            else if (!Label1.Visible) // e njejte me Label1.Visible==false
            {

                Label1.Visible = true;
                Label1.ForeColor = System.Drawing.Color.Green;
            }

            if (Label2.Visible)
            {

                Label2.Visible = false;
            }

            else
            {

                Label2.Visible = true;
                Label2.ForeColor = System.Drawing.Color.Green;


            }




        }
    }
}