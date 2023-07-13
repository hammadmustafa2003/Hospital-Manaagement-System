using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FrontEnd_NayaPakistan.DAL; 

namespace FrontEnd_NayaPakistan
{
    public partial class registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SignUpDoctor(object sender, EventArgs e)
        {
            string first_name = docFirstname.Text;
            string last_name = docLastname.Text;
            string email = docEmail.Text;
            string phone_number = docMobile.Text;
            string gender = docGender.Text;
            string salary = docSalary.Text;
            string specilization = docSpecilization.Text;
            string username = docUsernamesignup.Text;
            string password = docPasswordsignup.Text;
            string dept = docDeptsignup.Text;


            myDAL dal = new myDAL();


            dal.signUpDoctor(first_name,last_name,email,phone_number,gender,salary,specilization,username,password,dept);
            Response.Redirect("registeration.aspx");


        }

        protected void SignUpNurse(object sender, EventArgs e)
        {
            string first_name = NursefirstName.Text;
            string last_name = NurseLastName.Text;
            string email = Nurseemail.Text;
            string phone_number = Nursemobile.Text;
            string gender = NurseGender.Text;
            string salary = Nursesalary.Text;
            string specilization = NurseSpecilization.Text;
            string username = Nurseusername.Text;
            string password = Nursepassword.Text;
            string dept = NurseDept.Text;


            myDAL dal = new myDAL();


            dal.signUpNurse(first_name, last_name, email, phone_number, gender, salary, specilization, username, password, dept);
            Response.Redirect("registeration.aspx");


        }

        protected void SignUpStaff(object sender, EventArgs e)
        {
            string first_name = Stafffirstname.Text;
            string last_name = Stafflastname.Text;
            string email = Staffemail.Text;
            string phone_number = Staffmobile.Text;
            string gender = Staffgender.Text;
            string salary = StaffSalary.Text;
            string username = Staffusername.Text;
            string password = StaffPassword.Text;


            myDAL dal = new myDAL();


            dal.signUpStaff(first_name, last_name, email, phone_number, gender, salary, username, password);
            Response.Redirect("registeration.aspx");


        }

        protected void SignUpPatient(object sender, EventArgs e)
        {
            string first_name = PatientFname.Text;
            string last_name = PaitentLname.Text;
            string email = Patientemail.Text;
            string phone_number = Patientmobile.Text;
            string gender = PatientGender.Text;
            string username = Patientusername.Text;
            string password = PatientPassword.Text;
            string dept = Patientdpet.Text;


            myDAL dal = new myDAL();


            dal.signUpPatient(first_name, last_name, email, phone_number, gender, username, password, dept);
            Response.Redirect("registeration.aspx");


        }

        protected void SignUpAdmin(object sender, EventArgs e)
        {
            string first_name = adminFName.Text;
            string last_name = adminLname.Text;
            string email = adminEmail.Text;
            string phone_number = adminPhoneNumber.Text;
            string gender = adminGender.Text;
            string username = adminUsername.Text;
            string password = adminPassword.Text;
            string salary = adminSalary.Text;

            myDAL dal = new myDAL();


            dal.signUpAdmin(first_name, last_name, email, phone_number, gender, salary, username, password);
            Response.Redirect("registeration.aspx");


        }
    }
}