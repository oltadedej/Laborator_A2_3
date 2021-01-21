using Laborator_A2_3.Laborator3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator3
{
    public partial class MenaxhoRecordePhoneBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack) // definojme qe jemi ne load te faqes
            {
                Configuration con = new Configuration();
                // veprimet me lista
                con.phoneBooks.Select(i => i.PhoneBookPersonName).ToList(); // select phonebookpersonname from emertabele 
                con.phoneBooks.Where(i => i.IdPhoneBook == 2).Select(i => i.PhoneBookPersonName).ToList(); // select phonebookpersonname from emertabele where idphone=2 
                bool exist = con.phoneBooks.Where(i => i.IdPhoneBook == 2).Any(); // select count (*) from emertabele where idphone=2 
                con.phoneBooks.Where(i => i.IdPhoneBook == 2 && i.PhoneBookPersonName.Equals("Test1")).ToList();
                con.phoneBooks.Where(i => i.IdPhoneBook == 2 && i.PhoneBookPersonName.Equals("Test1")).FirstOrDefault();

                ddl.DataSource = con.phoneBooks;
                ddl.DataTextField = "PhoneBookPersonName";
                ddl.DataValueField = "IdPhoneBook";
                ddl.DataBind(); // shfaq burimin e te dhenave ne web


            }

        }

        protected void btnShto_Click(object sender, EventArgs e)
        {

            PhoneBook phoneBookNew = new PhoneBook();
            if (!String.IsNullOrEmpty(txtpersonName.Text))
            {
                phoneBookNew.PhoneBookPersonName = txtpersonName.Text;

            }

            if (!String.IsNullOrEmpty(txtphoneNumber.Text))
            {
                phoneBookNew.PhoneNumber = txtphoneNumber.Text;

            }


            if (!String.IsNullOrEmpty(RadioButtonList1.SelectedValue))
            {
                //"2" ==2
                phoneBookNew.PhoneType = Convert.ToInt32(RadioButtonList1.SelectedValue);
            }

            Configuration con = new Configuration();
            phoneBookNew.IdPhoneBook = con.phoneBooks.Count() + 1;
            con.phoneBooks.Add(phoneBookNew);
            ddl.DataSource = con.phoneBooks;
            ddl.DataTextField = "PhoneBookPersonName";
            ddl.DataValueField = "IdPhoneBook";
            ddl.DataBind(); // shfaq burimin e te dhenave ne web


        }

        protected void btnfshi_Click(object sender, EventArgs e)
        {

            //fshi elementet nga lista
            if (!String.IsNullOrEmpty(ddl.SelectedValue))
            {
                int idphonebook = 0;
                idphonebook = Convert.ToInt32(ddl.SelectedValue);

                Configuration con = new Configuration();


                bool exist = con.phoneBooks.Where(i => i.IdPhoneBook == idphonebook).Any();
                if(exist)
                {
                    //elementi ekziston
                    //gjeje dhe fshije
                    PhoneBook itemToDelete = con.phoneBooks.Where(i => i.IdPhoneBook == idphonebook).FirstOrDefault();

                    if (itemToDelete != null)
                    {
                        //fshije nga lista
                        con.phoneBooks.Remove(itemToDelete);
                        ddl.DataSource = con.phoneBooks;
                        ddl.DataTextField = "PhoneBookPersonName";
                        ddl.DataValueField = "IdPhoneBook";
                        ddl.DataBind(); // shfaq burimin e te dhenave ne web

                    }


                }


            }



        }

        protected void btnTransfero_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(ddl.SelectedValue))
            {
                // transfero te dhenat
                Response.Redirect("Afisho.aspx?IdPhoneBook="+ ddl.SelectedValue);




            }
        }
    }
}