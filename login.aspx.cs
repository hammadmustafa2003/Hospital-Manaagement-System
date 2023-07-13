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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void loginDoctorClick (object sender, EventArgs e)
        {
            
            String username = doctorUsername.Text, password = doctorPassword.Text;
            myDAL getData=new myDAL();


            int docID = 0;
            docID = getData.getDoctorID(username, password);
            if (docID != -1)
            {
                Response.Cookies["ID"].Value = docID.ToString();
                Response.Redirect("profileDoc.aspx");
            }
            else
            {
                docPlaceHolder.Controls.Add(new Literal() { Text= "<div style=\"color: rgb(255, 0, 0); font-size: 16px; text-align: center;\"> Invalid Username or Password</div>" });
            }


        }

        protected void loginNurseClick(object sender, EventArgs e)
        {

            String username = nurseUsername.Text, password = nursePassword.Text;
            myDAL getData = new myDAL();


            int nurseID = 0;
            nurseID = getData.getnurseID(username, password);
            if (nurseID != -1)
            {
                Response.Cookies["ID"].Value = nurseID.ToString();
                Response.Redirect("profileNurse.aspx");
            }
            else
            {
                nursePlaceHolder.Controls.Add(new Literal() { Text = "<div style=\"color: rgb(255, 0, 0); font-size: 16px; text-align: center;\"> Invalid Username or Password</div>" });
            }


        }

        protected void patientLogin_Click(object sender, EventArgs e)
        {
            String username = patientUsername.Text, password = patientPassword.Text;
            myDAL getData = new myDAL();


            int patientID = 0;
            patientID= getData.getPatientID(username, password);
            if (patientID != -1)
            {
                Response.Cookies["ID"].Value = patientID.ToString();
                Response.Redirect("profilePatient.aspx");
            }
            else
            {
                patientPlaceHolder.Controls.Add(new Literal() { Text = "<div style=\"color: rgb(255, 0, 0); font-size: 16px; text-align: center;\"> Invalid Username or Password</div>" });
            }
        }



        /////////////////
        protected void loginAdminClick(object sender, EventArgs e)
        {
            String username = adminUsername.Text, password = adminPassword.Text;
            myDAL getData = new myDAL();

            int adminID = 0;
            adminID = getData.getAdminID(username, password);
            if (adminID != -1)
            {
                Response.Cookies["ID"].Value = adminID.ToString();
                Response.Redirect("profileAdmin.aspx");
            }
            else
            {
                adminPlaceHolder.Controls.Add(new Literal() { Text = "<div style=\"color: rgb(255, 0, 0); font-size: 16px; text-align: center;\"> Invalid Username or Password</div>" });
            }


        }

        protected void loginStaffClick(object sender, EventArgs e)
        {
            String username = staffUsername.Text, password = staffPassword.Text;
            myDAL getData = new myDAL();

            int staffID = 0;
            staffID = getData.getStaffID(username, password);
            if (staffID != -1)
            {
                Response.Cookies["ID"].Value = staffID.ToString();
                Response.Redirect("profileStaff.aspx");
            }
            else
            {
                StaffPlaceHolder.Controls.Add(new Literal() { Text = "<div style=\"color: rgb(255, 0, 0); font-size: 16px; text-align: center;\"> Invalid Username or Password</div>" });
            }


        }
    }
}