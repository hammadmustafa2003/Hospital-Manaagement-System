<%@ Page Title="" Language="C#" MasterPageFile="~/Doctor.Master" AutoEventWireup="true" CodeBehind="profileStaff.aspx.cs" Inherits="FrontEnd_NayaPakistan.WebForm1" %>
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


            <link rel="stylesheet" href="../assets/css/Doc.css">
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
                <a class="navbar-brand" href="#"><span class="text-primary">Naya</span>-Pakistan Staff</a>


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

            <table>
                <tr>
                
                    <td><div class="sideMenu">
                        <ul >
                            <li><a class="btn-light" href="profileStaff.aspx">Profile</a></li>
                            <li><a href="reqProfileChangeStaff.aspx">Request Change</a></li>
                            <li><a href="login.aspx">Log out</a></li>
                        </ul>
                    </div></td>

                    <td><div>
                        <asp:DetailsView ID="StaffBasicDesc" runat="server" Height="350px" Width="700px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" CssClass="Table1">
                            <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White"  />
                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        </asp:DetailsView>
                    </div></td>
                </tr>
            </table>

        
    </html>
</asp:Content>
