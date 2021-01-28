using Laborator_A2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_3.Laborator4
{
    public partial class modifikoStudent : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var studentid = Request.QueryString["studentId"];
                if (studentid != null)
                {
                    int studentId = Convert.ToInt32(studentid);
                    using (University_LaboratorEntities dbcontext = new University_LaboratorEntities())
                    {
                        var student = dbcontext.Students.ToList().FirstOrDefault(i => i.StudentId == studentId);
                        if (student != null)
                        {
                            txtName.Text = student.Emer;
                            txtSurname.Text = student.Mbiemer;
                            txtEnrollmentDate.Text = student.EnrollmentDate.ToString("dd/MM/yyyy");
                        }
                    }
                }
            }
        }

        protected void btnModiko_Click(object sender, EventArgs e)
        {
            var studentid = Request.QueryString["studentId"];
            if (studentid != null)
            {
                int studentId = Convert.ToInt32(studentid);
                if (studentId != 0)
                {
                    bool isOk = true;
                    try
                    {


                        using (University_LaboratorEntities entities = new University_LaboratorEntities())
                        {
                            int itemIndex = entities.Students.ToList().FindIndex(item => item.StudentId == studentId);

                            if (!String.IsNullOrEmpty(txtName.Text))
                            {
                                entities.Students.ToList()[itemIndex].Emer = txtName.Text;
                            }
                            if (!String.IsNullOrEmpty(txtSurname.Text))
                            {
                                entities.Students.ToList()[itemIndex].Mbiemer = txtSurname.Text;
                            }
                            if (!String.IsNullOrEmpty(txtEnrollmentDate.Text))
                            {
                                entities.Students.ToList()[itemIndex].EnrollmentDate = Convert.ToDateTime(txtEnrollmentDate.Text);
                            }

                            entities.SaveChanges();
                        }

                    }
                    catch (Exception ex)
                    {
                        isOk = false;
                    }

                    if (isOk) Response.Redirect("Students.aspx");
                    else
                    {
                        error.Text = "Probleme gjate modifikimit te studentit";
                    }
                }
            }
        }
    }
}