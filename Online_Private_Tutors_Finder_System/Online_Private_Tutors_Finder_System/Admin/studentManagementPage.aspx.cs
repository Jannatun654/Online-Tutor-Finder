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
	public partial class studentManagementPage : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString;

		protected void Page_Load(object sender, EventArgs e)
		{

			gridStudentInfo.DataBind();
			
		}

		protected void btnSearch_Click(object sender, EventArgs e)
		{
			
			getStudentByID();
		}

		void getStudentByID()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();

				}
				SqlCommand cmd = new SqlCommand("select * from student_tbl where studentID='" + txtStudentSearch.Text.Trim() + "'", con);
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.HasRows)
				{
					while (dr.Read())
					{
						txtSname.Text = dr.GetValue(1).ToString();
						txtStudentId.Text = dr.GetValue(2).ToString();
						txtSusernane.Text = dr.GetValue(3).ToString();
						txtSEmail.Text = dr.GetValue(4).ToString();
						txtSAddress.Text = dr.GetValue(5).ToString();						
						txtSPassword.Text = dr.GetValue(6).ToString();
						
						

					}

				}
				else
				{
					Response.Write("<script>alert('Student ID Not Valid... Pleass Provide Your Valid Student ID');</script>");
				}

			}
			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");
			}
		}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			validateForm();
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



		/// Create Function New Student 
		public void createNewStudent()
		{
			try
			{
				


				if (txtSname.Text == "")
				{
					lblStudentName.Visible = true; 
				}
				else if (txtStudentId.Text == "")
				{
					lblStudentId.Visible = true;
				}
				else if (txtSusernane.Text == "")
				{
					lblUsername.Visible = true;
				}
				else if (txtSEmail.Text == "")
				{
					lblEmail.Visible = true;
				}
				else if (txtSAddress.Text == "")
				{
					lblAddress.Visible=true;
				}
				else if (txtSPassword.Text == "")
				{
					lblPassword.Visible = true;
				}

				else
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
					Response.Write("<script>alert('Successfully Add New Student ');</script>");
					ClearTextBox();
					gridStudentInfo.DataBind();
				}

				
			}
			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");

			}
		}


	

		protected void btnUpdate_Click(object sender, EventArgs e)
		{
			validateForm();
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
				updateStudentTable();
			}
		}


		public void updateStudentTable()
		{
			try
			{
				lblStudentName.Visible = false;
				lblStudentId.Visible = false;
				lblUsername.Visible = false;
				lblEmail.Visible = false;
				lblAddress.Visible = false;
				lblPassword.Visible = false;


				if (txtSname.Text == "")
				{
					lblStudentName.Visible = true;
				}
				else if (txtStudentId.Text == "")
				{
					lblStudentId.Visible = true;
				}
				else if (txtSusernane.Text == "")
				{
					lblUsername.Visible = true;
				}
				else if (txtSEmail.Text == "")
				{
					lblEmail.Visible = true;
				}
				else if (txtSAddress.Text == "")
				{
					lblAddress.Visible = true;
				}
				else if (txtSPassword.Text == "")
				{
					lblPassword.Visible = true;
				}

				else
				{
					SqlConnection con = new SqlConnection(strcon);
					con.Open();
					string query = "UPDATE student_tbl SET name=@name,studentID=@studentID,username=@username,email=@email,address=@address,password=@password WHERE studentID='"+txtStudentSearch.Text.Trim()+"'" ;
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@name", txtSname.Text.Trim());
					cmd.Parameters.AddWithValue("@studentID", txtStudentId.Text.Trim());
					cmd.Parameters.AddWithValue("@username", txtSusernane.Text.Trim());
					cmd.Parameters.AddWithValue("@email", txtSEmail.Text.Trim());
					cmd.Parameters.AddWithValue("@address", txtSAddress.Text.Trim());
					cmd.Parameters.AddWithValue("@password", txtSPassword.Text.Trim());					
					cmd.ExecuteNonQuery();
					con.Close();
					Response.Write("<script>alert('Successfully Student Data Updated ');</script>");
					ClearTextBox();
					gridStudentInfo.DataBind();
				}


			}
			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");

			}
		}


		protected void btnDelete_Click(object sender, EventArgs e)
		{
			if (txtStudentSearch.Text=="")
			{
				Response.Write("<script>alert('Pless Find Your Student ID');</script>");
			}
			else
			{
				deleteStudent();
			}
			
		}

		public void deleteStudent()
		{
			SqlConnection con = new SqlConnection(strcon);
			con.Open();
			string query = "DELETE FROM student_tbl  WHERE studentID='" + txtStudentSearch.Text.Trim() + "'";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();
			con.Close();
			Response.Write("<script>alert('Successfull Deleted Student ');</script>");
			ClearTextBox();
			gridStudentInfo.DataBind();
		}
		protected void btnClear_Click(object sender, EventArgs e)
		{
			validateForm();
			ClearTextBox();
		}

		public void ClearTextBox()
		{
			txtSname.Text = null;
			txtStudentId.Text = null;
			txtSusernane.Text = null;
			txtSEmail.Text = null;
			txtSAddress.Text = null;
			txtSPassword.Text = null;
			txtStudentSearch.Text = null;


		}
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

		void validateForm()
		{
			lblStudentName.Visible = false;
			lblStudentId.Visible = false;
			lblUsername.Visible = false;
			lblEmail.Visible = false;
			lblAddress.Visible = false;
			lblPassword.Visible = false;
		}

	}
}