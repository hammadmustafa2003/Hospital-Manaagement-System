using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FrontEnd_NayaPakistan.DAL;


namespace FrontEnd_NayaPakistan
{
    public partial class reqProfileChangeStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addEditRequestDoc(object sender, EventArgs e)
        {
            string toChange = toChangeAttributeStaff.Text;
            string changeVal = newVal.Text;
            string toChangeSQL = string.Empty;
            string retVal = string.Empty;


            retVal = Request.Cookies["ID"].Value;
            int id = int.Parse(retVal);
            myDAL dal = new myDAL();
            if (!string.IsNullOrEmpty(toChange))
            {
                switch (toChange)
                {
                    case "Email":
                        toChangeSQL = "email";
                        break;
                    case "Phone Number":
                        toChangeSQL = "phoneNumber";
                        break;
                    case "Salary":
                        toChangeSQL = "salary";
                        break;
                    case "Username":
                        toChangeSQL = "username";
                        break;
                    case "Password":
                        toChangeSQL = "password";
                        break;
                }
            }


            if (toChangeSQL == "salary")
            {
                int changeValInt = int.Parse(changeVal);
                dal.requestDataChange("staff", toChangeSQL, id, changeValInt, string.Empty);
            }
            else
            {
                dal.requestDataChange("staff", toChangeSQL, id, 0, changeVal);
            }
            Response.Redirect("profileStaff.aspx");

        }


    }
}