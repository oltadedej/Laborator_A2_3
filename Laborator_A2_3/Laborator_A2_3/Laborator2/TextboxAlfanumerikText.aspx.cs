using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator2
{
    public partial class TextboxAlfanumerikText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AfishoniText(object sender, EventArgs e)
        {

            lbl1.Text = "";
            if (!String.IsNullOrEmpty(TextBox1.Text))
            {
                if(TextBox1.Text.Contains(" "))
                {
                    string[] array = TextBox1.Text.Split(' ');

                    lbl1.Text = "Numri i elementeve te array eshte:" + array.Length;
                   
                }

            }

        }
    }
}