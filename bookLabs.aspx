<%@ Page Title="" Language="C#" MasterPageFile="~/Doctor.Master" AutoEventWireup="true" CodeBehind="bookLabs.aspx.cs" Inherits="FrontEnd_NayaPakistan.bookLabs" %>
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
                            <li><a class="btn-light" href="profileDoc.aspx">Profile</a></li>
                            <li><a href="appointmentsDoctor.aspx">Appointments</a></li>
                            <li><a href="reqProfileChangeDoc.aspx">Request Change</a></li>
                            <li><a href="bookLabs.aspx">Book Labs</a></li>
                            <li> <a href="login.aspx">Log out</a></li>
                        </ul>
                    </div></td>

                    <td><div>
                        <table style="border-spacing:10px; border-collapse:separate">
                            <tr>
                                <td> 
                                    <asp:Label ID="labSelect" runat="server" Text="Select lab:" Font-Size="Small"></asp:Label>
                                </td>

                                <td>
                                    <asp:DropDownList ID="LabsName" runat="server" CssClass="dropDownDoc"> </asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td> 
                                    <asp:Label ID="testSelect" runat="server" Text="Select Test:" Font-Size="Small"></asp:Label>
                                </td>

                                <td>
                                    <asp:DropDownList ID="TestName" runat="server" CssClass="dropDownDoc"> </asp:DropDownList>
                                </td>
                            </tr>

                            
                            <tr>
                                <td> 
                                    <asp:Label ID="DateSelect" runat="server" Text="Select Date:" Font-Size="Small"></asp:Label>
                                </td>

                                <td>
                                    <asp:TextBox ID="testDate" TextMode="Date" runat="server" CssClass="dropDownDoc"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td> 
                                    <asp:Label ID="Label1" runat="server" Text="Select Time:" Font-Size="Small"></asp:Label>
                                </td>

                                <td>
                                    <asp:TextBox ID="testTime" TextMode="Time" runat="server" CssClass="dropDownDoc"></asp:TextBox>
                                </td>
                            </tr>
                            
                            <tr>
                                <td> 
                                    <asp:Label ID="patientSelect" runat="server" Text="Select Patient:" Font-Size="Small"></asp:Label>
                                </td>

                                <td></td>
                            </tr>
                        </table>

                        <asp:GridView ID="patientsList" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="550px" AutoGenerateSelectButton="True">
                                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                <SortedDescendingHeaderStyle BackColor="#242121" />
                        </asp:GridView> <br /> <br /> 

                        <asp:Button id="bookLabSubmit" Text="Book" CssClass="subBtn" runat="server" OnClick="bookLabSubmit_Click"/> 
                    </div></td>
                </tr>
            </table>
        </body>
        
    </html>
</asp:Content>
