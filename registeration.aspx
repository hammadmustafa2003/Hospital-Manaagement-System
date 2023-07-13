<%@ Page Title="" Language="C#" MasterPageFile="~/Doctor.Master" AutoEventWireup="true" CodeBehind="registeration.aspx.cs" Inherits="FrontEnd_NayaPakistan.registeration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<!DOCTYPE html>
    <html lang="en">
        <head>
            <meta charset="UTF-8">
            <meta name="viewport" content="width=device-width, initial-scale=1.0">

            <meta http-equiv="X-UA-Compatible" content="ie=edge">

            <meta name="copyright" content="MACode ID, https://macodeid.com/">

            <title>NAYA PAKISTAN HMS</title>

            <link rel="stylesheet" href="../assets/css/maicons.css">

            <link rel="stylesheet" href="../assets/css/bootstrap.css">

            <link rel="stylesheet" href="../assets/vendor/owl-carousel/css/owl.carousel.css">

            <link rel="stylesheet" href="../assets/vendor/animate/animate.css">

            <link rel="stylesheet" href="../assets/css/theme.css">

            
              <link rel="stylesheet" href="../assets/css/tabs.css">

              <link rel="stylesheet" href="../assets/css/login.css">

            <link href="../assets/css/registration.css" rel="stylesheet" />
  </head>


        <body>
        <header>
            <div class="topbar">
              <div class="container">
                <div class="row">
                  <div class="col-sm-8 text-sm">
                    <div class="site-info">
                      <a href="#"><span class="mai-call text-primary"></span> +00 123 4455 6666</a>
                      <span class="divider">|</span>
                      <a href="#"><span class="mai-mail text-primary"></span> hammadmustafa@pti.com</a>
                    </div>
                  </div>
                  <div class="col-sm-4 text-right text-sm">
                    <div class="social-mini-button">
                      <a href="#"><span class="mai-logo-facebook-f"></span></a>
                      <a href="#"><span class="mai-logo-twitter"></span></a>
                      <a href="#"><span class="mai-logo-instagram"></span></a>
                    </div>
                  </div>
                </div> <!-- .row -->
              </div> <!-- .container -->
            </div> <!-- .topbar -->

            <!-- Back to top button -->
            <div class="back-to-top"></div>
            <nav class="navbar navbar-expand-lg navbar-light shadow-sm">
                <div class="container">
                <a class="navbar-brand" href="#"><span class="text-primary">Naya</span>-Pakistan Doctor</a>


                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupport" aria-controls="navbarSupport" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarSupport">
                    <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="default.aspx">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="about.aspx">About Us</a>
                    </li>

                    <li class="nav-item">
                        <a class="nav-link" href="contact.aspx">Contact</a>
                    </li>


                    </ul>
                </div> <!-- .navbar-collapse -->
                </div> <!-- .container -->
            </nav>
        </header>
        
            </body>
    </html>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <html>
        <head>
            <link rel="stylesheet" href="../assets/css/Doc.css">
        </head>
        <body>
            <table>
                <tr>
                
                    <td><div class="sideMenu">
                        <ul >
                            <li><a href="profileAdmin.aspx">Profile</a></li>
                            <li><a href="ViewExpensesAdmin.aspx">View Expenses</a></li>
                            <li><a href="ManageChangeRequest.aspx">Manage Change Requests</a></li>
                            <li><a href="reqProfileChangeAdmin.aspx">Request Change</a></li>
                            <li><a class="btn-light" href="registeration.aspx">Register New User</a></li>
                            <li><a href="login.aspx">Log out</a></li>
                        </ul>
                    </div></td>


                    <td>
                        <div class="tabs"> 

                    <input type="radio" name="tabs" id="tabone" checked="checked">
                    <label for="tabone">Doctor</label>
                    <div class="tab page-section bg-light">

                          <div class="row justify-content-center ">
                    <div class="col-lg-10">
            
                      <div class="row ">
                        
                        <div class = "inner-row-reg">

                            <h3>SignUp Doctor ! </h3>
                          
                            <label>FirstName</label>
                            <asp:TextBox ID="docFirstname" runat="server"> </asp:TextBox>
                         
                          <label>LastName</label>
                            <asp:TextBox ID="docLastname" runat="server"> </asp:TextBox>

                             <label>Email</label>
                            <asp:TextBox ID="docEmail" runat="server"> </asp:TextBox>
                         
                          <label>Phone Number</label>
                            <asp:TextBox ID="docMobile"  runat="server"> </asp:TextBox>

                               <label>Salary</label>
                            <asp:TextBox ID="docSalary" runat="server" > </asp:TextBox>
                         
                          <label>Gender</label>
                            <asp:TextBox ID="docGender" runat="server"> </asp:TextBox> 

                               <label>Specilizaiton</label>
                            <asp:TextBox ID="docSpecilization" runat="server"> </asp:TextBox>

                              <label>Username</label>
                            <asp:TextBox ID="docUsernamesignup" runat="server"> </asp:TextBox> 

                               <label>Password</label>
                            <asp:TextBox ID="docPasswordsignup" TextMode="Password" runat="server"> </asp:TextBox>

                              <label>Department</label>
                              <asp:TextBox ID="docDeptsignup" runat="server"> </asp:TextBox>

                              <asp:Button ID="docSignup" runat="server" Text="Sign Up" OnClick="SignUpDoctor"/>
          
                        </div>
            
                      </div>
            
                    </div>
                  </div>
                      </div>
        
                    <input type="radio" name="tabs" id="tabtwo">
                    <label for="tabtwo">Nurse</label>
                    <div class="tab page-section bg-light">
                         <div class="row justify-content-center ">
                    <div class="col-lg-10">
            
                      <div class="row ">
                        
                        <div class = "inner-row-reg">
                            <h3>SignUp Nurse ! </h3>
                          
                            <label>FirstName</label>
                            <asp:TextBox ID="NursefirstName" runat="server"> </asp:TextBox>
                         
                          <label>LastName</label>
                            <asp:TextBox ID="NurseLastName" runat="server"> </asp:TextBox>

                             <label>Email</label>
                            <asp:TextBox ID="Nurseemail" runat="server"> </asp:TextBox>
                         
                          <label>Phone Number</label>
                            <asp:TextBox ID="Nursemobile"  runat="server"> </asp:TextBox>

                               <label>Salary</label>
                            <asp:TextBox ID="Nursesalary" runat="server" > </asp:TextBox>
                         
                          <label>Gender</label>
                            <asp:TextBox ID="NurseGender" runat="server"> </asp:TextBox> 

                               <label>Specilizaiton</label>
                            <asp:TextBox ID="NurseSpecilization" runat="server"> </asp:TextBox>

                              <label>Username</label>
                            <asp:TextBox ID="Nurseusername" runat="server"> </asp:TextBox> 

                               <label>Password</label>
                            <asp:TextBox ID="Nursepassword" TextMode="Password" runat="server"> </asp:TextBox>

                              <label>Department</label>
                              <asp:TextBox ID="NurseDept" runat="server"> </asp:TextBox>

                              <asp:Button ID="NurseSignup" runat="server" Text="Sign Up" OnClick="SignUpNurse"/>
          
                        </div>
            
                      </div>
            
                    </div>
                  </div>
              
                      </div>
   
            <input type="radio" name="tabs" id="tabthree">
            <label for="tabthree">Staff</label>
            <div class="tab page-section bg-light">
                         <div class="row justify-content-center ">
                    <div class="col-lg-10">
            
                      <div class="row ">
                        
                        <div class = "inner-row-reg">
                            <h3>SignUp Staff ! </h3>
                          
                            <label>FirstName</label>
                            <asp:TextBox ID="Stafffirstname" runat="server"> </asp:TextBox>
                         
                          <label>LastName</label>
                            <asp:TextBox ID="Stafflastname" runat="server"> </asp:TextBox>

                             <label>Email</label>
                            <asp:TextBox ID="Staffemail" runat="server"> </asp:TextBox>
                         
                          <label>Phone Number</label>
                            <asp:TextBox ID="Staffmobile"  runat="server"> </asp:TextBox>

                               <label>Salary</label>
                            <asp:TextBox ID="StaffSalary" runat="server" > </asp:TextBox>
                         
                          <label>Gender</label>
                            <asp:TextBox ID="Staffgender" runat="server"> </asp:TextBox> 

                              <label>Username</label>
                            <asp:TextBox ID="Staffusername" runat="server"> </asp:TextBox> 

                               <label>Password</label>
                            <asp:TextBox ID="StaffPassword" TextMode="Password" runat="server"> </asp:TextBox>

                              <asp:Button ID="Staffsiginup" runat="server" Text="Sign Up" OnClick="SignUpStaff"/>
          
                        </div>
            
                      </div>
            
                    </div>
                  </div>
              
                      </div>

            <input type="radio" name="tabs" id="tabfour">
            <label for="tabfour">Patient</label>
            <div class="tab page-section bg-light">
                         <div class="row justify-content-center ">
                    <div class="col-lg-10">
            
                      <div class="row ">
                        
                        <div class = "inner-row-reg">
                            <h3>SignUp Patient ! </h3>
                          
                            <label>FirstName</label>
                            <asp:TextBox ID="PatientFname" runat="server"> </asp:TextBox>
                         
                          <label>LastName</label>
                            <asp:TextBox ID="PaitentLname" runat="server"> </asp:TextBox>

                             <label>Email</label>
                            <asp:TextBox ID="Patientemail" runat="server"> </asp:TextBox>
                         
                          <label>Phone Number</label>
                            <asp:TextBox ID="Patientmobile"  runat="server"> </asp:TextBox>
                         
                          <label>Gender</label>
                            <asp:TextBox ID="PatientGender" runat="server"> </asp:TextBox> 

                              <label>Username</label>
                            <asp:TextBox ID="Patientusername" runat="server"> </asp:TextBox> 

                               <label>Password</label>
                            <asp:TextBox ID="PatientPassword" TextMode="Password" runat="server"> </asp:TextBox>

                              <label>Department</label>
                              <asp:TextBox ID="Patientdpet" runat="server"> </asp:TextBox>

                              <asp:Button ID="Patientsignup" runat="server" Text="Sign Up" OnClick="SignUpPatient"/>
          
                        </div>
            
                      </div>
            
                    </div>
                  </div>
              
                      </div>

<input type="radio" name="tabs" id="tabfive">
            <label for="tabfive">Admin</label>
            <div class="tab page-section bg-light">
                         <div class="row justify-content-center ">
                    <div class="col-lg-10">
            
                      <div class="row ">
                        
                        <div class = "inner-row-reg">
                            <h3>SignUp Admin ! </h3>
                          
                            <label>FirstName</label>
                            <asp:TextBox ID="adminFName" runat="server"> </asp:TextBox>
                         
                          <label>LastName</label>
                            <asp:TextBox ID="adminLname" runat="server"> </asp:TextBox>

                             <label>Email</label>
                            <asp:TextBox ID="adminEmail" runat="server"> </asp:TextBox>
                         
                          <label>Phone Number</label>
                            <asp:TextBox ID="adminPhoneNumber"  runat="server"> </asp:TextBox>

                               <label>Salary</label>
                            <asp:TextBox ID="adminSalary" runat="server" > </asp:TextBox>
                         
                          <label>Gender</label>
                            <asp:TextBox ID="adminGender" runat="server"> </asp:TextBox> 

                              <label>Username</label>
                            <asp:TextBox ID="adminUsername" runat="server"> </asp:TextBox> 

                               <label>Password</label>
                            <asp:TextBox ID="adminPassword" TextMode="Password" runat="server"> </asp:TextBox>

                              <asp:Button ID="adminSiginup" runat="server" Text="Sign Up" OnClick="SignUpAdmin"/>
          
                        </div>
            
                      </div>
            
                    </div>
                  </div>
              
                      </div>



              </div>
               </td>
                   </tr>

            </table>
        </body>
        
    </html>
</asp:Content>
