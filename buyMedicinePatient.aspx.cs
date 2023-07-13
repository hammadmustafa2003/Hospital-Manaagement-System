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
    public partial class buyMedicinePatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadMedicine();
        }
        protected void loadMedicine()
        {
            myDAL dal = new myDAL();
            DataSet ds = dal.getmedicinesList();
            medicineList.DataSource = ds;
            medicineList.DataBind();
        }

        protected void confirmBuy_Click(object sender, EventArgs e)
        {
            int medicineId;
            if (medicineList.SelectedIndex >= 0)
            {
                GridViewRow row = medicineList.Rows[medicineList.SelectedIndex];
                medicineId = int.Parse(row.Cells[1].Text);
                string quantityStr = quantity.Text;
                if (!string.IsNullOrEmpty(quantityStr))
                {
                    string idStr = Request.Cookies["ID"].Value;
                    int patientID = int.Parse(idStr);
                    int medQuantity=int.Parse(quantityStr);
                    myDAL dal = new myDAL();
                    dal.buyMedicine(patientID,medicineId,medQuantity);
                    Response.Redirect("profilePatient.aspx");
                }
            }
        }
    }
}