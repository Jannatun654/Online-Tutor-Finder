<%@ Page Title="Student Management Page ||Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="studentManagementPage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Admin.studentManagementPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<script type="text/javascript">
      $(document).ready(function () {
		  $("#gridStudentInfo").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
      });
	</script>
	<div class="row m-2">
		<div class="col-md-4  card ">
 <h1 class="text-center mb-2">Student Management</h1>
          <form>
			  <div class="form-group">
              <div class="input-group">
                      <asp:TextBox  placeholder="Enter Student ID" ID="txtStudentSearch" class="form-control" runat="server" TextMode="Number"></asp:TextBox>
                      <div class="input-group-append">
						  <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-secondary bg-secondary font-weight-bold text-light"  Text="Find" OnClick="btnSearch_Click" />
                      </div>
                </div>
			  </div>
           <div class="form-group">
				<asp:TextBox ID="txtSname" class="form-control"  placeholder="Name" runat="server"></asp:TextBox>
			   <asp:Label ID="lblStudentName" runat="server" Text="Pless Provide Student Name" ForeColor="Red" Visible="False"></asp:Label>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtStudentId" class="form-control" placeholder="Student Id"  runat="server" TextMode="Number"></asp:TextBox>
                <asp:Label ID="lblStudentId" runat="server" Text="Pless Provide Student ID" ForeColor="Red" Visible="False"></asp:Label>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtSusernane" class="form-control" placeholder="Username"  runat="server"></asp:TextBox>
                <asp:Label ID="lblUsername" runat="server" Text="Pless Provide Username" ForeColor="Red" Visible="False"></asp:Label>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtSEmail" class="form-control" placeholder="Email"  runat="server" TextMode="Email"></asp:TextBox>
                <asp:Label ID="lblEmail" runat="server" Text="Pless Provide Email" ForeColor="Red" Visible="False"></asp:Label>
            </div>
            <div class="form-group">
				<asp:TextBox ID="txtSAddress" class="form-control"  placeholder="Address"  runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
                <asp:Label ID="lblAddress" runat="server" Text="Pless Provide Address" ForeColor="Red" Visible="False"></asp:Label>
            </div>

            <div class="form-group">				
				<asp:TextBox ID="txtSPassword" class="form-control" placeholder="Password"  runat="server" ></asp:TextBox>
                <asp:Label ID="lblPassword" runat="server" Text="Pless Provide Password" ForeColor="Red" Visible="False"></asp:Label>
            </div>
			  <div class="row">
				  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="btnAdd" class="btn btn-primary btn-block" runat="server" Text="ADD" OnClick="btnAdd_Click" />
                       </div>
				  </div>
                  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="btnUpdate" class="btn btn-info btn-block" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
                       </div>
				  </div>
                  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="btnDelete" class="btn btn-block btn-danger" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
                       </div>
				  </div>
                  <div class="col-md-3">
                      <div class="text-center pt-2 pb-1">
        				<asp:Button ID="btnClear" class="btn  btn-block btn-warning" runat="server" Text="CLEAR" OnClick="btnClear_Click" />
                       </div>
				  </div>

			  </div>

          </form>
</div>

<div class="col-md-8 card   ">
 
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
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TutorefinderBDConnectionString %>" SelectCommand="SELECT [Id], [name], [studentID], [username], [email], [address], [password], [accountStatusId] FROM [student_tbl]"></asp:SqlDataSource>
           <div class="col ">                     
			 <asp:GridView CssClass=" table table-striped table-bordered table-responsive text-center " ID="gridStudentInfo" runat="server" AutoGenerateColumns="False" DataKeyNames="studentID" DataSourceID="SqlDataSource1">
				 <Columns>
					 <asp:BoundField DataField="Id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
					 <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
					 <asp:BoundField DataField="studentID" HeaderText="Student ID" ReadOnly="True" SortExpression="studentID" />
					 <asp:BoundField DataField="username" HeaderText="Username" SortExpression="username" />
					 <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
					 <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                     <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
				 </Columns>
			   </asp:GridView>                      
           </div>
        </div>

	</div>

</div>

	</div>

</asp:Content>
