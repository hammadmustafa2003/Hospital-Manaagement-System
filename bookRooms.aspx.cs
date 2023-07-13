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
    public partial class bookRooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        protected void LoadRooms()
        {
            myDAL dal = new myDAL();
            //setting data source of labs to the lab names from the database
            DataSet ds2 = dal.getFreeRooms();
            roomList.DataSource = ds2;
            roomList.DataBind();
        }

        protected void confirmBook_Click(object sender, EventArgs e)
        {
            int roomId;
            if (roomList.SelectedIndex >= 0)
            {
                string retVal = string.Empty;
                retVal = Request.Cookies["ID"].Value;
                int patientId = int.Parse(retVal);

                GridViewRow row = roomList.Rows[roomList.SelectedIndex];
                roomId = int.Parse(row.Cells[1].Text);
                string insertionDate = dischargeDate.Text;
                string insertionTime =dischargeTime.Text;
                if (!string.IsNullOrEmpty(insertionDate) && !string.IsNullOrEmpty(insertionTime))
                {
                    myDAL dal = new myDAL();
                    dal.bookRoom(roomId, patientId, insertionTime, insertionDate);
                    Response.Redirect("profilePatient.aspx");
                }
            }
        }
    }
}