using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Rivalda
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedItem != null)
            {
                if (!string.IsNullOrEmpty(DropDownList1.SelectedItem.Text))
                {
                    if(DropDownList1.SelectedItem.Text.Contains("E kuqe"))
                    {
                        Label2.Text = "Numri i elementeve te listes eshte " + DropDownList1.Items.Count;
                    }
                    else
                    {
                        TextBox txt = new TextBox();
                        txt.Text = "Ngjyra e zgjedhur eshte " + DropDownList1.SelectedItem.Text;
                        form1.Controls.Add(txt);

                    }

                }
            }
        }
    }
}