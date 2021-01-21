using Laborator_A2_3.Laborator3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator3
{
    public partial class Afisho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //gjejme informacionin e phonebook tek lista
                if (Request.QueryString["IdPhoneBook"] != null)
                {
                    int IdPhoneBook = 0;
                    IdPhoneBook = Convert.ToInt32(Request.QueryString["IdPhoneBook"].ToString());

                    //a ekziston ky element ne liste?
                    Configuration con = new Configuration();
                    if (con.phoneBooks.Where(i => i.IdPhoneBook == IdPhoneBook).Any())
                    {
                        //ekziston elementi
                        //gjej elementin
                        PhoneBook phoneBook = con.phoneBooks.Where(i => i.IdPhoneBook == IdPhoneBook).FirstOrDefault();
                        //i jap vlera labels nga fushat e elementit
                        labelPhoneBookPersonName.Text = phoneBook.PhoneBookPersonName;
                        lblPhoneBookNumer.Text = phoneBook.PhoneNumber;
                        //perdorimi i rregullit ternar   kusht --> ? --> else percaktohet nepermjet :
                        lblPhoneBookType.Text = phoneBook.PhoneType == 1 ? "Cellular" : phoneBook.PhoneType == 2 ? "Work" : "Home";

                        //if (phoneBook.PhoneType == 1)
                        //{
                        //    lblPhoneBookType.Text = "Cellular";
                        //}
                        //else if (phoneBook.PhoneType == 2)
                        //{
                        //    lblPhoneBookType.Text = "Work";
                        //}
                        //else
                        //{
                        //    lblPhoneBookType.Text = "Home";
                        //}

                    }
                }
            }

        }
    }
}