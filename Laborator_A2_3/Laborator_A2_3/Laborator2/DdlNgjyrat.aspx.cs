using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator2
{
    public partial class DdlNgjyrat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem newItem = new ListItem();
            newItem.Text = "E verdhe";
            ddlNgjyrat.Items.Add(newItem);
        }
    }
}