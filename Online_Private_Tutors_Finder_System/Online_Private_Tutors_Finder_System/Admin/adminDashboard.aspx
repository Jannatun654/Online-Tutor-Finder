<%@ Page Title="Admin Dashboard Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="adminDashboard.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Admin.adminDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container-fluid mt-2 mb-2">
<div class="jumbotron">
<div class="row w-100">
        <div class="col-md-4">
            <div class="card border-info mx-sm-1 p-3">
                <div class="text-info text-center mt-3"><h4>Tutoris Hired</h4></div>
                
                <div class="text-info text-center mt-2"><asp:Label runat="server" ID="lbltutorisHired">0</asp:Label></div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card border-success mx-sm-1 p-3">
                <div class="text-success text-center mt-3"><h4>Earnings</h4></div>
                <div class="text-success text-center mt-2"><asp:Label runat="server" ID="lblEarnings">0</asp:Label></div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card border-danger mx-sm-1 p-3">
                <div class="text-danger text-center mt-3"><h4>Tutors Registened</h4></div>
                <div class="text-danger text-center mt-2"><asp:Label runat="server" ID="lblTutorsRegistened">0</asp:Label></div>
            </div>
        </div>
       
     </div>
</div>
	</div>
</asp:Content>
