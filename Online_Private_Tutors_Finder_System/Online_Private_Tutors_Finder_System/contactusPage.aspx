<%@ Page Title="Contact Us Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="contactusPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.contactusPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">	
    <div class="row m-2">
		<div class="col-md-6 m-auto card ">
 <h1 class="text-center mb-2">Contact Us</h1>
			 <form>
            <div class="form-group">
				<asp:TextBox ID="txtContactName" class="form-control" placeholder="Name" required="required" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtContactEmail" class="form-control" placeholder="Email" required="required" runat="server" TextMode="Email"></asp:TextBox>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtContactPhone" class="form-control" placeholder="Phone Numbar" required="required" runat="server" TextMode="Phone"></asp:TextBox>
            </div>

            <div class="form-group">
				<asp:TextBox ID="txtContactSubject" class="form-control" placeholder="Subject" required="required" runat="server" ></asp:TextBox>
            </div>
                 <div class="form-group">
				<asp:TextBox ID="txtContactMessage" class="form-control" placeholder="Message" required="required" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
            </div>
            <div class="text-center pt-2 pb-1">
				<asp:Button ID="btnContactSubmit" class="btn btn-primary btn-block" runat="server" Text="Send" OnClick="btnContactSubmit_Click" />
            </div>
          </form>

</div>
	</div>

</asp:Content>
