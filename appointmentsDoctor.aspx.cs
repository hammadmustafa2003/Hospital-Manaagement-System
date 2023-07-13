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
    public partial class appointmentsDoctor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadAppointment();
        }

        protected void loadAppointment()
        {
            string retVal = string.Empty;
            retVal = Request.Cookies["ID"].Value;
            int id = int.Parse(retVal);

            myDAL dal = new myDAL();
            //dal.getDoctorDetailsFromID(id);
            
            DataSet ds = dal.getAppFromDocId(id);
            DocPastApp.DataSource = ds.Tables[0];
            DocUpcomingApp.DataSource = ds.Tables[1];  
            DocPastApp.DataBind();
            DocUpcomingApp.DataBind();
        }
    }
}