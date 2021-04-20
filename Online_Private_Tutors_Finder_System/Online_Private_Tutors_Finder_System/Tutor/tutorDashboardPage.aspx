<%@ Page Title="Tutor Dashboard Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="tutorDashboardPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Tutor.tutorDashboardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		<div class="container-fluid mt-2 mb-2">
<div class="jumbotron">
<div class="row w-100">
        <div class="col-md-4">
            <div class="card border-info mx-sm-1 p-3">
                <div class="text-info text-center mt-3"><h4>Hiread Number</h4></div>
                
                <div class="text-info text-center mt-2"><asp:Label runat="server" ID="lblHireadNumber">0</asp:Label></div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card border-success mx-sm-1 p-3">
                <div class="text-success text-center mt-3"><h4>Monthly Income</h4></div>
                <div class="text-success text-center mt-2"><asp:Label runat="server" ID="lblMonthlyIncome">0</asp:Label></div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card border-danger mx-sm-1 p-3">
                <div class="text-danger text-center mt-3"><h4>Ratings</h4></div>
                <div class="text-danger text-center mt-2"><asp:Label runat="server" ID="lblRatings">0 Tks</asp:Label></div>
            </div>
        </div>
       
     </div>
</div>
	</div>

</asp:Content>
