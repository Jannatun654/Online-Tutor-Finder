<%@ Page Title="Tutore Management Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="tutorManagementPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Admin.tutorManagementPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		<div class="row m-2">
		<div class="col-md-4  card ">
 <h1 class="text-center mb-2">Tutor Management</h1>
          <form>
			  <div class="form-group">
              <div class="input-group">
                      <asp:TextBox  placeholder="Enter Tutor ID" ID="txtTutorSearch" class="form-control" runat="server" TextMode="Number"></asp:TextBox>
                      <div class="input-group-append">
                        <button class="btn btn-outline-secondary bg-secondary font-weight-bold text-light" type="button" id="button-addon2">Search</button>
                      </div>
                </div>
			  </div>
			  <div class="form-group">
                <label >Name</label>
				<asp:TextBox ID="txtTName" class="form-control" placeholder="Name" required="required" runat="server"></asp:TextBox>
            </div>
                 <div class="form-group">
                     <label >University Name</label>
				<asp:TextBox ID="txtUniversityName" class="form-control" placeholder="University Name" required="required" runat="server"></asp:TextBox>
            </div>
                 <div class="form-group">
                     <label >Department Name</label>
				<asp:TextBox ID="txtDepartmentName" class="form-control" placeholder="Department Name" required="required" runat="server"></asp:TextBox>
            </div>
                  <div class="form-group">
                     <label >Subject Name</label>
				<asp:TextBox ID="txtSubjectName" class="form-control" placeholder="Subject Name" required="required" runat="server"></asp:TextBox>
            </div>
                  <div class="form-group">
                <label >Address</label>
				<asp:TextBox ID="txtAddress" class="form-control" placeholder="Address" required="required" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </div>

            <div class="form-group">
                <label >Username</label>
				<asp:TextBox ID="txtTUsername" class="form-control" placeholder="Username" required="required" runat="server"></asp:TextBox>
            </div>


            <div class="form-group">
                <label >Email</label>
				<asp:TextBox ID="txtTEmail" class="form-control" placeholder="Email" required="required" runat="server" TextMode="Email"></asp:TextBox>
            </div>
              

            <div class="form-group">
                <label >Password</label>
				<asp:TextBox ID="txtTPassword" class="form-control" placeholder="Password" required="required" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="form-group">
                <label >Upload Picture</label>
				<asp:FileUpload ID="uploadPicture" class="form-control"  required="required" runat="server" />
            </div>
               <div class="form-group">
                            <label >Upload Demo Video</label>
				            <asp:FileUpload ID="uploadVideo" class="form-control"  required="required" runat="server" />
                </div>
			  <div class="row">
				  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="TutorsRegister"  class="btn btn-primary btn-block" runat="server" Text="ADD" />
                       </div>
				  </div>
                  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="Button1" class="btn btn-info btn-block" runat="server" Text="UPDATE" />
                       </div>
				  </div>
                  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="Button2" class="btn btn-block btn-danger" runat="server" Text="DELETE" />
                       </div>
				  </div>
                  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="Button3" class="btn  btn-block btn-warning" runat="server" Text="CLEAR" />
                       </div>
				  </div>

			  </div>
              </form>
			  </div>
              
<div class="col-md-8  card ">
 	<div class=" card-body m-0  p-0">
         <div class="row">
                     <div class="col ">                     
                           <h4 class="text-center">Student Information</h4>                       
                     </div>
        </div>
        <div class="row">
                     <div class="col">                     
						 <hr />                       
                     </div>
        </div>
        <div class="row">
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TutorefinderBDConnectionString %>" SelectCommand="SELECT [id], [name], [universityName], [departmentName], [subjectName], [address], [username], [email], [password], [ImageLink], [demoVideoLink] FROM [tutors_tbl]"></asp:SqlDataSource>
           <div class="col ">                     
			   <asp:GridView CssClass=" table table-striped table-bordered table-responsive text-center " ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
				   <Columns>
					   <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
					   <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
					   <asp:BoundField DataField="universityName" HeaderText="universityName" SortExpression="universityName" />
					   <asp:BoundField DataField="departmentName" HeaderText="departmentName" SortExpression="departmentName" />
					   <asp:BoundField DataField="subjectName" HeaderText="subjectName" SortExpression="subjectName" />
					   <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
					   <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
					   <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
					   <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
					   <asp:BoundField DataField="ImageLink" HeaderText="ImageLink" SortExpression="ImageLink" />
					   <asp:BoundField DataField="demoVideoLink" HeaderText="demoVideoLink" SortExpression="demoVideoLink" />
				   </Columns>
			   </asp:GridView>            
           </div>
        </div>

	</div>


</div>
          
</div>




</asp:Content>
