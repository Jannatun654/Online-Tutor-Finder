<%@ Page Title="Tutore Rating Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="addedTutorRatingPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Parents.addedTutorRetingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		<div class="row m-2">
		<div class="col-md-6 m-auto card ">
 <h1 class="text-center mb-2">Add Tutor Rating</h1>

<form>
	
  <div class="form-group">
    <label >Tutor Name</label>
	  <asp:TextBox ID="txttutorName" CssClass="form-control" placeholder="Tutor Name"  runat="server" ></asp:TextBox>
  </div>
  <div class="form-group">
    <label >Rating Tutor of Five</label>
	  <asp:TextBox ID="txtRating" CssClass="form-control" placeholder="Rating Tutor of Five" required="required" runat="server" TextMode="Number"></asp:TextBox>
  </div>
	<asp:Button ID="btnSubmitReting" CssClass=" mb-3 btn btn-primary mb-2 btn-block" runat="server" Text="Submit Ratings" />

</form>
</div>
	</div>

</asp:Content>
