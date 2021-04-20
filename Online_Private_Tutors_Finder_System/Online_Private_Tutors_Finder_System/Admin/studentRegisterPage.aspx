<%@ Page Title=" Student Registation Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="studentRegisterPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Admin.studentRegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row m-2">
		<div class="col-md-6 m-auto card ">
 <h1 class="text-center mb-2">Registation Now</h1>

          <form>
            <div class="form-group">
				<asp:TextBox ID="txtSname" class="form-control"  placeholder="Name" required="required" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtStudentId" class="form-control" placeholder="Student Id" required="required" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtSusernane" class="form-control" placeholder="Username" required="required" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtSEmail" class="form-control" placeholder="Email" required="required" runat="server" TextMode="Email"></asp:TextBox>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtSAddress" class="form-control"  placeholder="Address" required="required" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </div>

            <div class="form-group">
				<asp:TextBox ID="txtSPassword" class="form-control" placeholder="Password" required="" runat="server" TextMode="Password"></asp:TextBox>
            </div>
             <div class="text-center pt-2 pb-1">
				<asp:Button ID="StudentRegister" class="btn btn-primary btn-block" runat="server" Text="Register" OnClick="StudentRegister_Click" />
              </div>
          </form>
</div>
	</div>

</asp:Content>
