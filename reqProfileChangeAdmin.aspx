﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Patient.Master" AutoEventWireup="true" CodeBehind="reqProfileChangeAdmin.aspx.cs" Inherits="FrontEnd_NayaPakistan.reqProfileChangeAdmin" %>
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
                <a class="navbar-brand" href="#"><span class="text-primary">Naya</span>-Pakistan Admin</a>


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
                            <li><a class="btn-light" href="reqProfileChangeAdmin.aspx">Request Change</a></li>
                            <li><a href="registeration.aspx">Register New User</a></li>
                            <li><a href="login.aspx">Log out</a></li>
                        </ul>
                    </div></td>

                    <td><div>
                        <table style="border-spacing:10px; border-collapse:separate">
                            <tr>
                                <td> 
                                    <asp:Label ID="toChangeAtt" runat="server" Text="What do you want to change?   " Font-Size="Small"></asp:Label>
                                </td>

                                <td>
                                    <asp:DropDownList ID="toChangeAttribute" runat="server" CssClass="dropDownDoc">
                                        <asp:ListItem>Email</asp:ListItem>
                                        <asp:ListItem>Phone Number</asp:ListItem>
                                        <asp:ListItem>Salary</asp:ListItem>
                                        <asp:ListItem>Username</asp:ListItem>
                                        <asp:ListItem>Password</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td> 
                                    <asp:Label ID="newValLabel" runat="server" Text="Enter the new Value:   " Font-Size="Small"></asp:Label>
                                </td>

                                <td>
                                    <asp:TextBox ID="newVal" runat="server" CssClass="dropDownDoc"> </asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td> </td>

                                <td>
                                    <asp:Button ID="admSubButton" runat="server" Text="SUBMIT" CssClass="subBtn" OnClick="addEditRequestAdm"> </asp:Button>
                                </td>
                            </tr>



                        </table>

                    </div></td>
                </tr>
            </table>
        </body>
        
    </html>
</asp:Content>

