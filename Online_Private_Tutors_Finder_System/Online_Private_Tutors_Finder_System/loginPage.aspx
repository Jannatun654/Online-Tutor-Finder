<%@ Page Title="Login Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.loginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row m-2">
		<div class="col-md-6 m-auto card ">
 <h1 class="text-center mb-2">Login Now</h1>

<form>
	 <div class="form-group">
    <label >Account Type</label>
		 <asp:DropDownList ID="ddlAccountType" CssClass="form-control" runat="server" required="required "></asp:DropDownList>
  </div>
  <div class="form-group">
    <label >Email address</label>
	  <asp:TextBox ID="txtEmail" CssClass="form-control" placeholder="Email"  runat="server" required="required" TextMode="Email"></asp:TextBox>
  </div>
  <div class="form-group">
    <label >Password</label>
	  <asp:TextBox ID="txtPassword" CssClass="form-control" placeholder="Password" required="required" runat="server" TextMode="Password"></asp:TextBox>
  </div>
	<asp:Button ID="btnLogin" CssClass=" mb-3 btn btn-primary mb-2 btn-block" runat="server" Text="Login" OnClick="btnLogin_Click" />

</form>
</div>
	</div>
</asp:Content>
