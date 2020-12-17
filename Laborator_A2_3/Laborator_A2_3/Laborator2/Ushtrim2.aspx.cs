using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator2
{
    public partial class Ushtrim2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            label1.Text = "Olta Dedej";
            femer.Checked = true;

            AfishimMesazhi.Text = "Pershendetje:" + label1.Text + " " + "Gjinia juaj eshte: " + femer.Text + "Data e sotm eshte: " + DateTime.Now.ToString("dd/MM/yyyy");
          //  AfishimMesazhi.Text = $"Pershendetje: {label1.Text} Gjinia juaj eshte {femer.Text} data e sotme eshte {DateTime.Now.ToString("dd/MM/yyyy")}";

        }
    }
}