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
    public partial class ViewExpensesAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadExpenses();
        }
        protected void loadExpenses()
        {
            string retVal = string.Empty;
            retVal = Request.Cookies["ID"].Value;
            int id = int.Parse(retVal);
            myDAL dal = new myDAL();
            DataSet ds = dal.getIncomingExpenses(id);
            //dal.getDoctorDetailsFromID(id);
            IncomingExpensesGridAppointment.DataSource = ds.Tables[0];
            IncomingExpensesGridAppointment.DataBind();

            IncomingExpensesGridTest.DataSource = ds.Tables[1];
            IncomingExpensesGridTest.DataBind();

            IncomingExpensesGridMedicines.DataSource = ds.Tables[2];
            IncomingExpensesGridMedicines.DataBind();

            //dal.getDoctorDetailsFromID(id);

            DataSet ds2 = dal.getOutgoingExpenses(id);

            OutgoingExpensesDoctor.DataSource = ds2.Tables[0];
            OutgoingExpensesNurse.DataSource = ds2.Tables[1];
            OutgoingExpensesStaff.DataSource = ds2.Tables[2];
            OutgoingExpensesStock.DataSource = ds2.Tables[3];

            OutgoingExpensesDoctor.DataBind(); 
            OutgoingExpensesNurse.DataBind();
            OutgoingExpensesStaff.DataBind();
            OutgoingExpensesStock.DataBind();





        }

    }
}