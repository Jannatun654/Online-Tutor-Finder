using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Online_Private_Tutors_Finder_System
{
	public partial class registation : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString;

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ParentRegister_Click(object sender, EventArgs e)
		{
			if (cheackStudentRoll())
			{
				Response.Write("<script>alert('Sorry!!! Child ID Already Exits Pleass Try another Child ID.....');</script>");

			}
			else if (cheackParentEmail())
			{
				Response.Write("<script>alert('Sorry!!! Parent Email Already Exits Pleass Try another Parent Email.....');</script>");
			}
			else
			{
				createNewParent();
				Response.Redirect("loginPage.aspx");
			}

		}

		bool cheackStudentRoll()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "select * from parents_table where childID='" + txtPchildId.Text.Trim() + "'";
				SqlCommand cmd = new SqlCommand(query, con);
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adp.Fill(dt);
				if (dt.Rows.Count >= 1)
				{
					return true;
				}
				else
				{
					return false;
				}

				con.Close();
			}

			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");
				return false;

			}


		}

		bool cheackParentEmail()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "select * from parents_table where email='" + txtPEmail.Text.Trim() + "'";
				SqlCommand cmd = new SqlCommand(query, con);
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adp.Fill(dt);
				if (dt.Rows.Count >= 1)
				{
					return true;
				}
				else
				{
					return false;
				}

				con.Close();
			}

			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");
				return false;
			}


		}

		public void createNewParent()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "INSERT INTO parents_table (name,childID,username,email,password,accountStatusID) VALUES(@name,@childID,@username,@email,@password,@accountStatusID)";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@name", txtPname.Text.Trim());
				cmd.Parameters.AddWithValue("@childID", txtPchildId.Text.Trim());
				cmd.Parameters.AddWithValue("@username", txtPusernane.Text.Trim());
				cmd.Parameters.AddWithValue("@email", txtPEmail.Text.Trim());
				cmd.Parameters.AddWithValue("@password", txtPPassword.Text.Trim());
				cmd.Parameters.AddWithValue("@accountStatusID", "2");
				int rowCount = cmd.ExecuteNonQuery();
				con.Close();
				if (rowCount > 0)
				{
					Response.Write("<script>alert('Successfully Added New Parents');</script>");
					ClearTextBox();
				}
				else
				{
					Response.Write("<script>alert('Pleass Valid Child Id');</script>");

				}

			}
			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");

			}
		}


		public void ClearTextBox()
		{
			txtPname.Text = null;
			txtPchildId.Text = null;
			txtPusernane.Text = null;
			txtPEmail.Text = null;
			txtPPassword.Text = null;


		}
	}
}