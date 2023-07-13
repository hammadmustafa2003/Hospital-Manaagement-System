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
    public partial class historyPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadPatientHistory();
        }

        protected void loadPatientHistory()
        {
            string retVal = string.Empty;
            retVal = Request.Cookies["ID"].Value;
            int id = int.Parse(retVal);

            myDAL dal = new myDAL();
            //dal.getDoctorDetailsFromID(id);

            DataSet ds = dal.getAppTestFromPatientId(id);
            PatientPastApp.DataSource = ds.Tables[0];
            PatientUpcomingApp.DataSource = ds.Tables[1];
            patientPastTest.DataSource=ds.Tables[2];
            patientUpTest.DataSource=ds.Tables[3];

            PatientPastApp.DataBind();
            PatientUpcomingApp.DataBind();
            patientPastTest.DataBind();
            patientUpTest.DataBind();

        }
    }
}