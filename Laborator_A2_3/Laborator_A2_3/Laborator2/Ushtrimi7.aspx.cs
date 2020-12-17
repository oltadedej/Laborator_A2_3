using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator2
{
    public partial class Ushtrimi7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Ngjyrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ngjyrat.SelectedItem != null)
            {
                if (Ngjyrat.SelectedItem.Text.Contains("e kuqe"))
                {
                    lblAfishimi.Text = "Dropdownlista permban: " + Ngjyrat.Items.Count + " elemente";
                }
                else
                {
                    TextBox txt = new TextBox();
                    txt.Text = Ngjyrat.SelectedItem.Text;
                    form1.Controls.Add(txt);
                    lblAfishimi.Text = string.Empty;
                }
            }
        }
    }
}