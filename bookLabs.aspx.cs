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
    public partial class bookLabs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadLabs();
            LoadTests();
            LoadPatients();
        }

        protected void LoadLabs()
        {
            myDAL dal = new myDAL();
            //setting data source of labs to the lab names from the database
            DataSet ds1 = dal.getLabsName();
            LabsName.DataTextField = ds1.Tables[0].Columns["name"].ToString();      
            LabsName.DataValueField = ds1.Tables[0].Columns["id"].ToString();
            LabsName.DataSource = ds1.Tables[0]; 
            LabsName.DataBind();

        }

        protected void LoadTests()
        {
            myDAL dal = new myDAL();
            //setting data source of labs to the lab names from the database
            DataSet ds2 = dal.getTestsfromLabsName();
            TestName.DataTextField = ds2.Tables[0].Columns["name"].ToString();
            TestName.DataValueField = ds2.Tables[0].Columns["id"].ToString();
            TestName.DataSource = ds2.Tables[0];
            TestName.DataBind();
        }

        protected void LoadPatients()
        {
            string retVal = string.Empty;
            retVal = Request.Cookies["ID"].Value;
            int docId = int.Parse(retVal);

            myDAL dal = new myDAL();
            //setting data source of labs to the lab names from the database
            DataSet ds = dal.getPatientsfromDocID(docId);
            /*TestName.DataTextField = ds.Tables[0].Columns["name"].ToString();
            TestName.DataValueField = ds.Tables[0].Columns["id"].ToString();*/
            patientsList.DataSource = ds;
            patientsList.DataBind();
            //add check button column
            //patientsList.
        }

        protected void bookLabSubmit_Click(object sender, EventArgs e)
        {
            int patientId;
            if (patientsList.SelectedIndex >= 0)
            {
                GridViewRow row = patientsList.Rows[patientsList.SelectedIndex];
                patientId = int.Parse(row.Cells[1].Text);
                string insertionDate = testDate.Text;
                string insertionTime = testTime.Text;
                int labid = int.Parse(LabsName.SelectedValue);
                int testid = int.Parse(TestName.SelectedValue);
                if (!string.IsNullOrEmpty(insertionDate) && !string.IsNullOrEmpty(insertionTime))
                {
                    myDAL dal = new myDAL();
                    dal.bookLabForPatient(labid,testid,patientId,insertionTime,insertionDate);
                }
            }
            

            

        }
    }
}