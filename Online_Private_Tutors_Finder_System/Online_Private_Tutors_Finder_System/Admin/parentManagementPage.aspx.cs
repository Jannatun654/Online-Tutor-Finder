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
	public partial class parentManagementPage : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString;

		protected void Page_Load(object sender, EventArgs e)
		{
			grideParentInformartion.DataBind();
		}

		protected void btnSearch_Click(object sender, EventArgs e)
		{
			getParentByID();
		}

		void getParentByID()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();

				}
				SqlCommand cmd = new SqlCommand("select * from parents_table where id='" + txtParentsSearch.Text.Trim() + "'", con);
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.HasRows)
				{
					while (dr.Read())
					{
						txtPname.Text = dr.GetValue(1).ToString();
						txtPchildId.Text = dr.GetValue(2).ToString();
						txtPusernane.Text = dr.GetValue(3).ToString();
						txtPEmail.Text = dr.GetValue(4).ToString();
						txtPPassword.Text = dr.GetValue(5).ToString();
						txtPchildId.ReadOnly=true;



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


		protected void ParentAdd_Click(object sender, EventArgs e)
		{
			validateForm();
			if (cheackStudentRollTableStudent())
			{
				Response.Write("<script>alert('Sorry!!! Enter the Valid Chaild Id ');</script>");
				

			}
			else if (cheackStudentRoll())
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
			}

		}

		protected void ParentUpdate_Click(object sender, EventArgs e)
		{
			validateForm();

		}

		protected void ParentDelete_Click(object sender, EventArgs e)
		{

		}

		protected void ParentClear_Click(object sender, EventArgs e)
		{

		}

		bool cheackStudentRollTableStudent()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "select * from student_tbl where studentID='" + txtPchildId.Text.Trim() + "'";
				SqlCommand cmd = new SqlCommand(query, con);
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adp.Fill(dt);
				if (dt.Rows.Count >= 1)
				{
					return false;
				}
				else
				{
					return true;
				}

				con.Close();
			}

			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");
				return false;

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
			try { 

			  if (txtPname.Text == "")
				{
				lblParentName.Visible = true;
			    }
				else if (txtPchildId.Text == "")
				{
					lblChildID.Visible = true;
				}
				else if (txtPusernane.Text == "")
				{
					lblParentUsername.Visible = true;
				}
				else if (txtPEmail.Text == "")
				{
					lblParentEmail.Visible = true;
				}

				else if (txtPPassword.Text == "")
				{
					lblPrentPassword.Visible = true;
				}
				else
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
						grideParentInformartion.DataBind();
						ClearTextBox();
					}
					else
					{
						Response.Write("<script>alert('Pleass Valid Child Id');</script>");

					}
				}

				

			}
			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");

			}
		}

		public void UpdateParent()
		{
			try
			{

				if (txtPname.Text == "")
				{
					lblParentName.Visible = true;
				}
				else if (txtPchildId.Text == "")
				{
					lblChildID.Visible = true;
				}
				else if (txtPusernane.Text == "")
				{
					lblParentUsername.Visible = true;
				}
				else if (txtPEmail.Text == "")
				{
					lblParentEmail.Visible = true;
				}

				else if (txtPPassword.Text == "")
				{
					lblPrentPassword.Visible = true;
				}
				else
				{
					SqlConnection con = new SqlConnection(strcon);
					con.Open();
					string query = " Update parents_table SET name=@name,childID=@childID,username=@username,email=@email,password=@password WHERE id='"+txtParentsSearch.Text.Trim()+"";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@name", txtPname.Text.Trim());
					cmd.Parameters.AddWithValue("@childID", txtPchildId.Text.Trim());
					cmd.Parameters.AddWithValue("@username", txtPusernane.Text.Trim());
					cmd.Parameters.AddWithValue("@email", txtPEmail.Text.Trim());
					cmd.Parameters.AddWithValue("@password", txtPPassword.Text.Trim());
					int rowCount = cmd.ExecuteNonQuery();
					con.Close();
					Response.Write("<script>alert('Successfully Updated Parents');</script>");
					grideParentInformartion.DataBind();
					ClearTextBox();
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

		void validateForm()
		{
			lblParentName.Visible = false;
			lblChildID.Visible = false;
			lblParentUsername.Visible = false;
			lblParentEmail.Visible = false;
			lblPrentPassword.Visible = false;
		}
	}
}
