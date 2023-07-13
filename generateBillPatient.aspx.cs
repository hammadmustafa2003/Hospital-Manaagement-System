using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using FrontEnd_NayaPakistan.DAL;

namespace FrontEnd_NayaPakistan
{
    public partial class generateBillPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadunpaidAppTests();
        }

        protected void loadunpaidAppTests()
        {
            string retVal = string.Empty;
            retVal = Request.Cookies["ID"].Value;
            int id = int.Parse(retVal), totalAmount=0;

            myDAL dal = new myDAL();

            DataSet ds = dal.getUnpaidItems(id,ref totalAmount);


            unpaidApp.DataSource = ds.Tables[0];
            unpaidTest.DataSource = ds.Tables[1];

            unpaidApp.DataBind();
            unpaidTest.DataBind();
        }

        protected void patientSubButton_Click(object sender, EventArgs e)
        {

            string retVal = string.Empty;
            retVal = Request.Cookies["ID"].Value;
            int id = int.Parse(retVal), totalAmount = 0;

            myDAL dal = new myDAL();

            dal.payUnpaidItems(id);
            Response.Redirect("profilePatient.aspx");
        }
    }
}