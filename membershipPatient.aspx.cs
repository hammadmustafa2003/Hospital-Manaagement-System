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
    public partial class membershipPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack) 
                LoadMemberships();
        }

        protected void LoadMemberships()
        {
            myDAL dal = new myDAL();
            //setting data source of labs to the lab names from the database
            DataSet ds1 = dal.getMemberships();
            membershipList.DataTextField = ds1.Tables[0].Columns["name"].ToString();
            membershipList.DataValueField = ds1.Tables[0].Columns["id"].ToString();
            membershipList.DataSource = ds1.Tables[0];
            membershipList.DataBind();

            string idStr = Request.Cookies["ID"].Value;
            int id = int.Parse(idStr);

            string currentMem = String.Empty;
            currentMem = dal.getMembershipOfPatient(id);
            currMembership.Controls.Add(new Literal() { Text = "<div style=\"color: rgb(255, 0, 0); font-size: 16px; text-align: center;\">" + currentMem + " </div>" });
        }

        protected void patientSubButton_Click(object sender, EventArgs e)
        {
            myDAL dal = new myDAL();

            string idStr = Request.Cookies["ID"].Value;
            int id = int.Parse(idStr);
            string mem = membershipList.SelectedItem.ToString();
            int membershipID = int.Parse(membershipList.SelectedItem.Value.ToString());
            int retVal = dal.buyMembership(id, membershipID);
            Response.Redirect("profilePatient.aspx");
        }
    }
}