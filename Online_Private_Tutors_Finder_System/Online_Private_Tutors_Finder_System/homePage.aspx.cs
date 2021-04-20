using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Online_Private_Tutors_Finder_System
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			Session["addtutore"] = "false";
		}

		protected void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "select * from tutors_tbl where (name like '%"+txttutorSearch.Text+ "%') or (universityName like '%" + txttutorSearch.Text + "%') or (departmentName like '%" + txttutorSearch.Text + "%') or (subjectName like '%" + txttutorSearch.Text + "%') or (address like '%" + txttutorSearch.Text + "%')";
				SqlCommand cmd = new SqlCommand(query, con);
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adp.Fill(dt);
				DataListTutorView.DataSourceID = null;
				
				DataListTutorView.DataSource = dt;
				DataListTutorView.DataBind();
				con.Close();
			}

			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");
				
			}

		}

		protected void DataListTutorView_ItemCommand(object source, DataListCommandEventArgs e)
		{
			Session["addtutore"] = "true";
			if(e.CommandName== "AddToTutore")
			{
				Response.Redirect("/Admin/AddToTutore.aspx?id=" + e.CommandArgument.ToString());
			}
		}
	}
}