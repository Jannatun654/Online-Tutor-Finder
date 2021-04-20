<%@ Page Title="Add Tutore Page|| Online Private Tutors Finder System" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AddToTutore.aspx.cs" Inherits="Online_Private_Tutors_Finder_System.Admin.AddToTutore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row m-2">
		<div class="col-md-6 m-auto card ">
 <h1 class="text-center mb-2">Bookign Tutore</h1>
		<asp:GridView ID="gridAddToTutior" CssClass=" table table-striped table-bordered  text-center " runat="server" AutoGenerateColumns="False" EmptyDataText="No Tutore avalable in Boking" ShowFooter="True" >
			<Columns>
				<asp:BoundField DataField="sno" HeaderText="Sr No">
				<ItemStyle HorizontalAlign="Center" />
				</asp:BoundField>
				<asp:BoundField DataField="tid" HeaderText="Tutore Name">
				<ItemStyle HorizontalAlign="Center" />
				</asp:BoundField>
				<asp:BoundField DataField="tname" HeaderText="Tutore ID">
				<ItemStyle HorizontalAlign="Center" />
				</asp:BoundField>
				<asp:ImageField DataImageUrlField="imageurl" HeaderText="TutoreImage">
					<ControlStyle Height="50px" Width="50px" />
					<ItemStyle HorizontalAlign="Center" />
				</asp:ImageField>
				
			</Columns>

		</asp:GridView>
			<div class="text-center">
				<asp:Button ID="btnAddTutore" CssClass="btn btn-info " runat="server" Text="Tutore Book Now" OnClick="btnAddTutore_Click" />
			</div>
			<div class="">
				<asp:HyperLink runat="server" ID="linkbtnhomepage" NavigateUrl="~/homePage.aspx">Go To Home Page</asp:HyperLink>
			</div>

</div>
	</div>

</asp:Content>
