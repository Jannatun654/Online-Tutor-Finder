<%@ Page Title="Home Page|| Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container-fluid">
		<div class="row container-fluid m-0 p-0">
			<div class="col img-fluid h-100 text-center "  style="background-image:url(img/teacher-collection.jpg)">
				<h1 class="mt-5 text-success ">Find Private Titors</h1>
				<h2 class=" text-warning">Expolore Top-Rated Tutors & more..</h2>

				<div class="row mb-5 p-2">
					<div class="col-md-6 m-auto">
                        <div class="input-group mb-3">
							<asp:TextBox ID="txttutorSearch" runat="server" placeholder="Search" class="form-control" TextMode="Search"></asp:TextBox>
                      <div class="input-group-append">
						  <asp:Button ID="btnSearch" runat="server" Text="Search"  class="btn btn-outline-secondary bg-secondary font-weight-bold text-light" OnClick="btnSearch_Click" />

                      </div>
                    </div>
					</div>
				</div>
			</div>

		</div>
        <div class="row container-fluid m-0 p-0 ">
			<div class="col text-center">
				<h2 class="mt-4"> Top Roted Tutors</h2>
				<h5 class="mb-5">Liked By Majority</h5>
			</div>
        </div>

		<asp:DataList ID="DataListTutorView" CssClass=""  runat="server" DataSourceID="SqlDataSource1" Height="293px" Width="310px" CellPadding="15"  RepeatDirection="Horizontal" RepeatColumns="4" HorizontalAlign="Justify" OnItemCommand="DataListTutorView_ItemCommand" >
			<ItemTemplate>
				<table class="card p-2" style="background-color: chocolate">
					
					<tr>
						<td>
								<asp:Image ID="tutorImage"  CssClass=" card-img-top"  runat="server" Width="278px" Height="279px" ImageUrl='<%# Eval("ImageLink")%>' />
						</td>
					
					</tr>
					<tr>
						<td class=" h5 text-light>
							Name:
							<asp:Label ID="lblTutorName" runat="server" Text='<%# Eval("name")%>'></asp:Label>
						</td>
					</tr>
					<tr>
						<td>
							Univercity : 
						<asp:Label ID="lblUniversityName" runat="server" Text='<%# Eval("universityName")%>'></asp:Label>

						</td>
					</tr>
					<tr>
						<td>
							Department : 
						<asp:Label ID="lblDepartmentName" runat="server" Text='<%# Eval("departmentName")%>'></asp:Label>

						</td>
					</tr>
					
					<tr>						
						
						<td>
							Subject : 
						<asp:Label ID="lblSubjectName" runat="server" Text='<%# Eval("subjectName")%>'></asp:Label>

						</td>

					</tr>
					<tr>						
						
						<td>
							Address : 
						<asp:Label ID="lblAddress" runat="server" Text='<%# Eval("address")%>'></asp:Label>

						</td>

					</tr>
					<tr class="row">
						<td class="col">
							<button type="button" class=" btn btn-dark text-light btn-block" data-toggle="modal" data-target="#staticBackdrop">
								Demo Lecture
							</button>
						</td>		
						<td class="col " >
							
							<asp:Button ID="AddTutore" class=" btn btn-primary btn-block" runat="server" Text="Select Tutor" CommandArgument='<%# Eval("id")%>' CommandName="AddToTutore"  />							
						</td>						
					</tr>

				</table>
<!-- Button trigger modal -->


<!-- Modal -->
<div class="modal fade " id="staticBackdrop" data-backdrop="static" data-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
  <div class="modal-dialog  ">
    <div class="modal-content bg-transparent border-0 ">
      <div class="">       
        <button type="button" class="close text-danger  rounded-circle p-2  bg-warning " data-dismiss="modal" aria-label="Close">
          <span class=" " aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class=" text-center">
		 <video width=450 Controls  >
			 <source src='<%# Eval("demoVideoLink") %>' type="video/mp4"  />
		 </video>
      </div>
     
    </div>
  </div>
</div>
			
			</ItemTemplate>
		</asp:DataList>
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TutorefinderBDConnectionString %>" SelectCommand="SELECT [id], [name], [ImageLink], [demoVideoLink], [universityName], [departmentName], [subjectName], [address] FROM [tutors_tbl]"></asp:SqlDataSource>

	</div>
</asp:Content>
