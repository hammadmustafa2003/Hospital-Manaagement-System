    <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FrontEnd_NayaPakistan.login" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
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
</head>
<body>

  <!-- Back to top button -->
  <div class="back-to-top"></div>

 
  <div class="page-banner overlay-dark bg-image" style="background-image: url(../assets/img/bg_image_1.jpg);">
    <div class="banner-section">
      <div class="container text-center wow fadeInUp">
        <nav aria-label="Breadcrumb">
          <ol class="breadcrumb breadcrumb-dark bg-transparent justify-content-center py-0 mb-2">
            <li class="breadcrumb-item"><a href="Default.aspx">Home</a></li>
            <li class="breadcrumb-item active" aria-current="page">Login</li>
          </ol>
        </nav>
        <h1 class="font-weight-normal"> Login </h1>
      </div> <!-- .container -->
    </div> <!-- .banner-section -->
  </div> <!-- .page-banner -->

  <div class="page-section bg-light">
    <div class="container">
      <div class="row justify-content-center">
        <div class="col-lg-10">
          <div class="tabs">

            <input type="radio" name="tabs" id="tabone" checked="checked">
            <label for="tabone">Doctor</label>
            <div class="tab">
            
              <div class="page-section bg-light">
                <div class="container">
                  <div class="row justify-content-center">
                    <div class="col-lg-10">
            
                      <div class="row">
                        
                        <div class = "inner-row">
                                <h3>Login as Doctor ! </h3>
                
                                <asp:PlaceHolder ID="docPlaceHolder" runat="server"> </asp:PlaceHolder>
                                <label>Username</label>
                                <asp:TextBox ID="doctorUsername" runat="server"> </asp:TextBox>
                             
                              <label>Password</label>
                                <asp:TextBox ID="doctorPassword" TextMode="Password" runat="server"> </asp:TextBox> <br> <br> <br>
                                <asp:Button ID="doctorLogin" runat="server" Text="Log In" OnClick="loginDoctorClick"/>
                        </div>
            
                      </div>
            
                    </div>
                  </div>
                </div> <!-- .container -->
              </div> <!-- .page-section -->
              </div>
        
            <input type="radio" name="tabs" id="tabtwo">
            <label for="tabtwo">Nurse</label>
            <div class="tab">
              
                <div class="page-section bg-light">
                <div class="container">
                  <div class="row justify-content-center">
                    <div class="col-lg-10">
            
                      <div class="row">
                        
                        <div class = "inner-row">
                                <h3>Login as Nurse ! </h3>
                                <asp:PlaceHolder ID="nursePlaceHolder" runat="server"> </asp:PlaceHolder>
                                <label>Username</label>
                                <asp:TextBox ID="nurseUsername" runat="server" > </asp:TextBox>
                             
                              <label>Password</label>
                                <asp:TextBox ID="nursePassword" TextMode="Password" runat="server"> </asp:TextBox> <br> <br> <br>
                                <asp:Button ID="nurseLogin" runat="server" Text="Log In" OnClientClick="loginNurseClick" OnClick="loginNurseClick"/>
                        </div>
            
                      </div>
            
                    </div>
                  </div>
                </div> <!-- .container -->
              </div> <!-- .page-section -->
              </div>
   
            <input type="radio" name="tabs" id="tabthree">
            <label for="tabthree">Staff</label>
            <div class="tab">
              
                <div class="page-section bg-light">
                <div class="container">
                  <div class="row justify-content-center">
                    <div class="col-lg-10">
            
                      <div class="row">
                        
                        <div class = "inner-row">
                                <h3>Login as Staff ! </h3>
                                <asp:PlaceHolder ID="StaffPlaceHolder" runat="server"> </asp:PlaceHolder>

                                <label>Username</label>
                                <asp:TextBox ID="staffUsername" runat="server"> </asp:TextBox>
                             
                              <label>Password</label>
                                <asp:TextBox ID="staffPassword" TextMode="Password" runat="server"> </asp:TextBox> <br> <br> <br>
                                <asp:Button ID="staffLogin" runat="server" Text="Log In" />
                
                        </div>
            
                      </div>
            
                    </div>
                  </div>
                </div> <!-- .container -->
              </div> <!-- .page-section -->
              </div>

            <input type="radio" name="tabs" id="tabfour">
            <label for="tabfour">Patient</label>
            <div class="tab">
              
                <div class="page-section bg-light">
                <div class="container">
                  <div class="row justify-content-center">
                    <div class="col-lg-10">
            
                      <div class="row">
                        
                        <div class = "inner-row">
                                <h3>Login as Patient ! </h3>
                                <asp:PlaceHolder ID="patientPlaceHolder" runat="server"> </asp:PlaceHolder>
                                <label>Username</label>
                                <asp:TextBox ID="patientUsername" runat="server" > </asp:TextBox>
                             
                              <label>Password</label>
                                <asp:TextBox ID="patientPassword" TextMode="Password" runat="server"> </asp:TextBox> <br> <br> <br>
                                <asp:Button ID="patientLogin" runat="server" Text="Log In" OnClick="patientLogin_Click" />
                        </div>
            
                      </div>
            
                    </div>
                  </div>
                </div> <!-- .container -->
              </div> <!-- .page-section -->
              </div>

              <input type="radio" name="tabs" id="tabfive">
            <label for="tabfive">Admin</label>
            <div class="tab">
              
                <div class="page-section bg-light">
                <div class="container">
                  <div class="row justify-content-center">
                    <div class="col-lg-10">
            
                      <div class="row">
                        
                        <div class = "inner-row">
                                <h3>Login as Admin ! </h3>
                                <asp:PlaceHolder ID="adminPlaceHolder" runat="server"> </asp:PlaceHolder>
                                <label>Username</label>
                                <asp:TextBox ID="adminUsername" runat="server" > </asp:TextBox>
                             
                              <label>Password</label>
                                <asp:TextBox ID="adminPassword" TextMode="Password" runat="server"> </asp:TextBox> <br> <br> <br>
                                <asp:Button ID="loginAdmin" runat="server" Text="Log In" OnClick="loginAdminClick" />
                        </div>
            
                      </div>
            
                    </div>
                  </div>
                </div> <!-- .container -->
              </div> <!-- .page-section -->
              </div>

            </div>
            </div>
            </div>
          </div>
          

        </div>
      </div>
    </div> <!-- .container -->
  </div> <!-- .page-section -->




<script src="../assets/js/jquery-3.5.1.min.js"></script>

<script src="../assets/js/bootstrap.bundle.min.js"></script>

<script src="../assets/vendor/owl-carousel/js/owl.carousel.min.js"></script>

<script src="../assets/vendor/wow/wow.min.js"></script>

<script src="../assets/js/theme.js"></script>
  
</body>
</html>


</asp:Content>

