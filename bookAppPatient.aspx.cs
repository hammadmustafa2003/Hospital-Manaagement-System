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
    public partial class bookAppPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTreamtmentTypes();
            LoadDoctors();
        }
        protected void LoadTreamtmentTypes()
        {
            myDAL dal = new myDAL();
            //setting data source of labs to the lab names from the database
            DataSet ds1 = dal.getTreatmentTypes();
            treatmentName.DataTextField = ds1.Tables[0].Columns["name"].ToString();
            treatmentName.DataValueField = ds1.Tables[0].Columns["id"].ToString();
            treatmentName.DataSource = ds1.Tables[0];
            treatmentName.DataBind();
        }
        protected void LoadDoctors()
        {
            myDAL dal = new myDAL();
            DataSet ds = dal.getDocsWithID();
            doctorList.DataSource = ds;
            doctorList.DataBind();
        }

        protected void bookAppSubmit_Click(object sender, EventArgs e)
        {
            int docId;
            if (doctorList.SelectedIndex >= 0)
            {
                GridViewRow row = doctorList.Rows[doctorList.SelectedIndex];
                docId = int.Parse(row.Cells[1].Text);
                string insertionDate = appDate.Text;
                string insertionTime = appTime.Text;
                int treatmentid = int.Parse(treatmentName.SelectedValue);
                if (!string.IsNullOrEmpty(insertionDate) && !string.IsNullOrEmpty(insertionTime))
                {
                    string idStr = Request.Cookies["ID"].Value;
                    int patientID = int.Parse(idStr);
                    myDAL dal = new myDAL();
                    dal.bookAppForPatient(patientID,docId,treatmentid, insertionTime, insertionDate);
                    Response.Redirect("profilePatient.aspx");
                }
            }
        }
    }
}