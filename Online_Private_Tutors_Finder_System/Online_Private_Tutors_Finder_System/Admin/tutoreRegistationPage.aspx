<%@ Page Title="Tutore Registation Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="tutoreRegistationPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Admin.tutoreRegistationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row m-2">
		<div class="col-md-6 m-auto card ">
 <h1 class="text-center mb-2">Tutore Registation Now</h1>
            <form>

				<div class="row">
                    <div class="col-md-6">
             <div class="form-group">
                     <label >Name</label>
				<asp:TextBox ID="txtTName" class="form-control" placeholder="Name" required="required" runat="server"></asp:TextBox>
            </div>

				   </div>
                     <div class="col-md-6">
                 <div class="form-group">
                     <label >University Name</label>
				<asp:TextBox ID="txtUniversityName" class="form-control" placeholder="University Name" required="required" runat="server"></asp:TextBox>
            </div>

				   </div>
				</div>

                <div class="row">
                    <div class="col-md-6">
                 <div class="form-group">
                     <label >Department Name</label>
				<asp:TextBox ID="txtDepartmentName" class="form-control" placeholder="Department Name" required="required" runat="server"></asp:TextBox>
            </div>

				   </div>
                     <div class="col-md-6">
                  <div class="form-group">
                     <label >Subject Name</label>
				<asp:TextBox ID="txtSubjectName" class="form-control" placeholder="Subject Name" required="required" runat="server"></asp:TextBox>
            </div>

				   </div>
				</div>
				<div class="row">
                  <div class="col-md-6">
                  <div class="form-group">
                <label >Address</label>
				<asp:TextBox ID="txtAddress" class="form-control" placeholder="Address" required="required" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </div>

				   </div>

                    <div class="col-md-6">
            <div class="form-group">
                <label >Username</label>
				<asp:TextBox ID="txtTUsername" class="form-control" placeholder="Username" required="required" runat="server"></asp:TextBox>
            </div>

				   </div>
				</div>
				<div class="row">
                    <div class="col-md-6">
            <div class="form-group">
                <label >Email</label>
				<asp:TextBox ID="txtTEmail" class="form-control" placeholder="Email" required="required" runat="server" TextMode="Email"></asp:TextBox>
            </div>

				   </div>
                     <div class="col-md-6">
            <div class="form-group">
                <label >Password</label>
				<asp:TextBox ID="txtTPassword" class="form-control" placeholder="Password" required="required" runat="server" TextMode="Password"></asp:TextBox>
            </div>

				   </div>
				</div>

				<div class="row">
					<div class="col-md-6">
                        <div class="form-group">
                            <label >Upload Picture</label>
				            <asp:FileUpload ID="uploadPicture" class="form-control"  required="required" runat="server" />
                        </div>
					</div>
                    	<div class="col-md-6">
                        <div class="form-group">
                            <label >Upload Demo Video</label>
							<small class="text-danger">Video Max with 50MB</small>
				            <asp:FileUpload ID="uploadVideo" class="form-control"  required="required" runat="server" />
                        </div>                       
					   </div>
				</div>

           

            <div class="text-center pt-2 pb-1">
				<asp:Button ID="TutorsRegister" class="btn btn-primary btn-block" runat="server" Text="Register" OnClick="TutorsRegister_Click" />
            </div>
          </form>

</div>
	</div>

</asp:Content>
