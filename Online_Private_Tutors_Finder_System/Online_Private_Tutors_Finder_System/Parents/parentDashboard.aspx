<%@ Page Title="Parent Dashboard Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="parentDashboard.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Parents.parentDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container-fluid mt-2 mb-2">
<div class="jumbotron">
<div class="row w-100">
        <div class="col-md-4">
            <div class="card border-info mx-sm-1 p-3">
                <div class="text-info text-center mt-3"><h4>Student Performance</h4></div>                
                <div class="text-info text-center mt-2"><asp:Label runat="server" ID="lblStudentPerformance">0</asp:Label></div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card border-success mx-sm-1 p-3">
                <div class="text-success text-center mt-3"><h4>Inquires Answered</h4></div>
                <div class="text-success text-center mt-2"><asp:Label runat="server" ID="lblInquiresAnswered">0</asp:Label></div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card border-danger mx-sm-1 p-3">
                <div class="text-danger text-center mt-3"><h4>Tutore Retting</h4></div>
                <div class="text-danger text-center mt-2"><asp:Label runat="server" ID="lblTutoreRetting">0</asp:Label></div>
            </div>
        </div>
       
     </div>
</div>
	</div>

</asp:Content>
