using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FrontEnd_NayaPakistan.DAL; 



namespace FrontEnd_NayaPakistan
{
    public partial class ManageChangeRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadChangeRequest();
        }

        protected void loadChangeRequest()
        {
            string retVal = string.Empty;
            retVal = Request.Cookies["ID"].Value;
            int id = int.Parse(retVal);
            myDAL dal = new myDAL();

            AllRequests.DataSource = dal.getRequests(id);
            AllRequests.DataBind(); 

        }

        protected void approveRequest(object sender, EventArgs e)
        {
            if (AllRequests.SelectedIndex >= 0)
            {
                GridViewRow row = AllRequests.Rows[AllRequests.SelectedIndex];
                int appId = int.Parse(row.Cells[1].Text);

                myDAL dal = new myDAL();

                dal.sendApproveRequest(appId);

                Response.Redirect("ManageChangeRequest.aspx");

            }

        }

        protected void disapproveRequest(object sender, EventArgs e)
        {

        }

    }
}