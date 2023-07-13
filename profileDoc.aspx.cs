using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FrontEnd_NayaPakistan.DAL;

namespace FrontEnd_NayaPakistan
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadProfile(); 
        }

        protected void loadProfile()
        {
            string retVal=string.Empty;
            retVal = Request.Cookies["ID"].Value;
            int id=int.Parse(retVal);
            myDAL dal=new myDAL();
            //dal.getDoctorDetailsFromID(id);
            DocBasicDesc.DataSource = dal.getDoctorDetailsFromID(id);
            DocBasicDesc.DataBind();  
        }
    }
}