<%@ Page Title="Parent Management Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="parentManagementPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Admin.parentManagementPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row m-2">
		<div class="col-md-4  card ">
 <h1 class="text-center mb-2">Parents Management</h1>
          <form>
			  <div class="form-group">
              <div class="input-group">
                      <asp:TextBox  placeholder="Enter Parents ID" ID="txtParentsSearch" class="form-control" runat="server" TextMode="Number"></asp:TextBox>
                      <div class="input-group-append">
						  <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-secondary bg-secondary font-weight-bold text-light"  Text="Find" OnClick="btnSearch_Click"  />
                      </div>
                </div>
			  </div>
                      <div class="form-group">
				<asp:TextBox ID="txtPname" class="form-control"  placeholder="Name"  runat="server"></asp:TextBox>
            			   <asp:Label ID="lblParentName" runat="server" Text="Pless Provide Parent Name" ForeColor="Red" Visible="False"></asp:Label>

                      </div>
            <div class="form-group">
				<asp:TextBox ID="txtPchildId" class="form-control" placeholder="Child Id"  runat="server" TextMode="Number"></asp:TextBox>
			   <asp:Label ID="lblChildID" runat="server" Text="Pless Provide Child ID" ForeColor="Red" Visible="False"></asp:Label>
           
                </div>


            <div class="form-group">
				<asp:TextBox ID="txtPusernane" class="form-control" placeholder="Username"  runat="server"></asp:TextBox>
           			   <asp:Label ID="lblParentUsername" runat="server" Text="Pless Provide Username" ForeColor="Red" Visible="False"></asp:Label>

                </div>
            <div class="form-group">
				<asp:TextBox ID="txtPEmail" class="form-control" placeholder="Email"  runat="server" TextMode="Email"></asp:TextBox>
          			   <asp:Label ID="lblParentEmail" runat="server" Text="Pless Provide Parent Email" ForeColor="Red" Visible="False"></asp:Label>

                </div>

            <div class="form-group">
				<asp:TextBox ID="txtPPassword" class="form-control" placeholder="Password"  runat="server"></asp:TextBox>
           		<asp:Label ID="lblPrentPassword" runat="server" Text="Pless Provide Parent Password" ForeColor="Red" Visible="False"></asp:Label>
                </div>
			  <div class="row">
				  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="ParentAdd" class="btn btn-primary btn-block" runat="server" Text="ADD" OnClick="ParentAdd_Click" />
                       </div>
				  </div>
                  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="ParentUpdate" class="btn btn-info btn-block" runat="server" Text="UPDATE" OnClick="ParentUpdate_Click" />
                       </div>
				  </div>
                  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="ParentDelete" class="btn btn-block btn-danger" runat="server" Text="DELETE" OnClick="ParentDelete_Click" />
                       </div>
				  </div>
                  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="ParentClear" class="btn  btn-block btn-warning" runat="server" Text="CLEAR" OnClick="ParentClear_Click" />
                       </div>
				  </div>

			  </div>

          </form>
</div>

<div class="col-md-8  card ">
        <div class=" card-body m-0  p-0">
              <div class="row">
                     <div class="col ">                     
                           <h4 class="text-center">Parent Information</h4>                       
                     </div>
        </div>
        <div class="row">
                     <div class="col">                     
						 <hr />                       
                     </div>
        </div>

			<div class="row ">
				<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TutorefinderBDConnectionString %>" SelectCommand="SELECT [id], [name], [childID], [username], [email], [password] FROM [parents_table]"></asp:SqlDataSource>
				<div class="col ">
					<asp:GridView ID="grideParentInformartion" CssClass=" table table-striped table-bordered table-responsive text-center table-responsive-mds " runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
				</div>
			</div>
        </div>

</div>

	</div>

</asp:Content>
