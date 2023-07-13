using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using FrontEnd_NayaPakistan.DAL;

namespace FrontEnd_NayaPakistan
{
    public partial class reviewPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            LoadAppointments();
        }
        protected void LoadAppointments()
        {
            string idStr = Request.Cookies["ID"].Value;
            int patientID = int.Parse(idStr);

            myDAL dal = new myDAL();
            DataSet ds = dal.getpastApp(patientID);
            appList.DataSource = ds;
            appList.DataBind();
        }

        protected void reviewAppSubmit_Click(object sender, EventArgs e)
        {
            int appId;
            if (appList.SelectedIndex >= 0)
            {
                string doctorRatingStr = docRating.Text;
                string staffsRatingStr = staffRating.Text;
                GridViewRow row = appList.Rows[appList.SelectedIndex];
                appId = int.Parse(row.Cells[1].Text);
                if (!string.IsNullOrEmpty(doctorRatingStr) && !string.IsNullOrEmpty(staffsRatingStr))
                {
                    int doctorRating = int.Parse(doctorRatingStr);
                    int staffsRating = int.Parse(staffsRatingStr);
                    if (doctorRating > 5) doctorRating = 5;
                    if (staffsRating > 5) staffsRating = 5;
                    string comments = commentRating.Text;
                    string idStr = Request.Cookies["ID"].Value;
                    int patientID = int.Parse(idStr);

                    myDAL dal = new myDAL();
                    dal.givereview(appId, doctorRating, staffsRating, comments);
                    Response.Redirect("profilePatient.aspx");
                }
            }
        }
    }
}