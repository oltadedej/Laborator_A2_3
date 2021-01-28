using Laborator_A2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator4
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (University_LaboratorEntities universityContext = new University_LaboratorEntities())
                {
                    gdvStudent.DataSource = universityContext.Students.ToList();
                    gdvStudent.DataBind();
                }
            }
        }

        protected void gdvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // GridView gv = (GridView)sender;
            // GridViewRow row = (GridViewRow)gdvStudent.Rows[e.RowIndex];

            int idStudentToDelete = (int)gdvStudent.DataKeys[e.RowIndex].Value;
            using (University_LaboratorEntities dbcontext = new University_LaboratorEntities())
            {
                Student st = null;
                st = dbcontext.Students.ToList().FirstOrDefault(c => c.StudentId == idStudentToDelete);
                if (st != null)
                {
                    dbcontext.Students.Remove(st);
                    dbcontext.SaveChanges();
                    gdvStudent.DataSource = dbcontext.Students.ToList();
                    gdvStudent.DataBind();
                }

            }

        }

        protected void gdvStudent_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //ka 2 menyra, ti beni dataitem as student se student eshte data member
            //ose te merrni id e me pas te beni kontroll tek lista per ket student
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Student student = e.Row.DataItem as Student;

                Label lblMessage = new Label();
                lblMessage = e.Row.FindControl("lbMsg") as Label;
                DateTime dt = new DateTime(2020, 10, 01);
                if (student.EnrollmentDate > dt)
                {
                    if (lblMessage != null)
                    {
                        lblMessage.Text = "Regjistrimi me vonese";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    if (lblMessage != null)
                    {
                        lblMessage.Text = "Regjistrimi ne kohe";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }

        }


        protected void gdvButtons_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "ModifikoStudent":
                    Response.Redirect("modifikoStudent.aspx?studentId="+ e.CommandArgument.ToString());
                    break;

                case "DetailStudent":
                     Response.Redirect("Afisho.aspx?studentId=" + e.CommandArgument.ToString());
                    break;
                //add other cases for other buttons


                default:
                    break;
            }
        }
    }
}