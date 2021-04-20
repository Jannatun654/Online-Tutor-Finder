using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Online_Private_Tutors_Finder_System.Admin
{
	public partial class studentRegisterPage : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void StudentRegister_Click(object sender, EventArgs e)
		{
			if (cheackStudentRoll())
			{
				Response.Write("<script>alert('Sorry!!! Student ID Already Exits Pleass Try another Student ID.....');</script>");

			}
			else if (cheackStudentEmail())
			{
				Response.Write("<script>alert('Sorry!!! Student Email Already Exits Pleass Try another Student Email.....');</script>");
			}
			else
			{
				createNewStudent();
			}
			

		}

		/// Cheack Student Roll 
		bool cheackStudentRoll()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "select * from student_tbl where studentID='" + txtStudentId.Text.Trim() + "'";
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

		/// Cheak Emaiil Id 
		bool cheackStudentEmail()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "select * from student_tbl where email='" + txtSEmail.Text.Trim() + "'";
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


		/// Create Function New Student 
		public void createNewStudent()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "INSERT INTO student_tbl (name,studentID,username,email,address,password,accountStatusId) VALUES(@name,@studentID,@username,@email,@address,@password,@accountStatusId)";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@name", txtSname.Text.Trim());
				cmd.Parameters.AddWithValue("@studentID", txtStudentId.Text.Trim());
				cmd.Parameters.AddWithValue("@username", txtSusernane.Text.Trim());
				cmd.Parameters.AddWithValue("@email", txtSEmail.Text.Trim());
				cmd.Parameters.AddWithValue("@address", txtSAddress.Text.Trim());
				cmd.Parameters.AddWithValue("@password", txtSPassword.Text.Trim());
				cmd.Parameters.AddWithValue("@accountStatusId", "4");
				cmd.ExecuteNonQuery();
				con.Close();
				Response.Write("<script>alert('Successfully Send Your Message ');</script>");
				ClearTextBox();
			}
			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");

			}
		}

		/// Clear TextBox Function 
		public void ClearTextBox()
		{
			txtSname.Text = null;
			txtStudentId.Text = null;
			txtSusernane.Text = null;
			txtSEmail.Text = null;
			txtSAddress.Text = null;
			txtSPassword.Text = null;
			

		}
	}
}