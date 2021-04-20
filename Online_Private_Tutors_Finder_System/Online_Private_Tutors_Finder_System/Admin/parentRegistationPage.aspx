<%@ Page Title="Parent Registation Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="parentRegistationPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Admin.parentRegistationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row m-2">
    <div class="col-md-6 m-auto card ">
 <h1 class="text-center mb-2">Registation Now</h1>
          <form>

            <div class="form-group">
				<asp:TextBox ID="txtPname" class="form-control"  placeholder="Name" required="required" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtPchildId" class="form-control" placeholder="Child Id" required="required" runat="server" TextMode="Number"></asp:TextBox>
            </div>


            <div class="form-group">
				<asp:TextBox ID="txtPusernane" class="form-control" placeholder="Username" required="required" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtPEmail" class="form-control" placeholder="Email" required="required" runat="server" TextMode="Email"></asp:TextBox>
            </div>

            <div class="form-group">
				<asp:TextBox ID="txtPPassword" class="form-control" placeholder="Password" required="" runat="server" TextMode="Password"></asp:TextBox>
            </div>
             <div class="text-center pt-2 pb-1">
				<asp:Button ID="ParentAdd" class="btn btn-primary btn-block" runat="server" Text="Register" OnClick="ParentAdd_Click" />
              </div>
          </form>

</div>
	</div>

</asp:Content>
