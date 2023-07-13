using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FrontEnd_NayaPakistan.DAL;

namespace FrontEnd_NayaPakistan
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadDoctorList();
        }

        public void loadDoctorList()
        {
            myDAL myDALobj = new myDAL();
            doctorList.DataSource = myDALobj.displayAllDoctors();
            doctorList.DataBind();
        }
    }
}