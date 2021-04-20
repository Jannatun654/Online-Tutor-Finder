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
	public partial class loginPage : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				accountTypeStatus();
			}
			
		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			int accoutnType = Convert.ToInt32(ddlAccountType.SelectedItem.Value);
			if (1 == accoutnType)
			{
				try
				{
					SqlConnection con = new SqlConnection(strcon);
					con.Open();
					string query = "SELECT * FROM admin_tbl WHERE ad_password='" + txtPassword.Text.Trim() + "' And email='" + txtEmail.Text.Trim() + "' and accountStatusId='" + accoutnType + "'";
					SqlCommand cmd = new SqlCommand(query, con);
					SqlDataReader rdr = cmd.ExecuteReader();
					if (rdr.HasRows)
					{
						while (rdr.Read())
						{
							Response.Write("<script>alert('login Success');</script>");
							Session["name"] = rdr.GetValue(1).ToString();
							Session["role"] = "admin";

						}
						Response.Redirect("homePage.aspx");
					}
					else
					{
						Response.Write("<script>alert('Invalid Credentials');</script>");

					}
					con.Close();
				}
				catch (Exception ex)
				{
					Response.Write("<script>alert('" + ex.Message + "');</script>");

				}
			}
			else if (2 == accoutnType)
			{
				try
				{
					SqlConnection con = new SqlConnection(strcon);
					con.Open();
					string query = "SELECT * FROM parents_table WHERE password='" + txtPassword.Text.Trim() + "' And email='" + txtEmail.Text.Trim() + "' and accountStatusId='" + accoutnType + "'";
					SqlCommand cmd = new SqlCommand(query, con);
					SqlDataReader rdr = cmd.ExecuteReader();
					if (rdr.HasRows)
					{
						while (rdr.Read())
						{
							Response.Write("<script>alert('Login Successful');</script>");
							Session["name"] = rdr.GetValue(1).ToString();
							Session["studentId"] = rdr.GetValue(2).ToString();

							Session["role"] = "parent";

						}
						Response.Redirect("homePage.aspx");
					}
					else
					{
						Response.Write("<script>alert('Invalid Credentials');</script>");

					}


					con.Close();
				}
				catch (Exception ex)
				{
					Response.Write("<script>alert('" + ex.Message + "');</script>");

				}
			}
			else if (3 == accoutnType)
			{
				try
				{
					SqlConnection con = new SqlConnection(strcon);
					con.Open();
					string query = "SELECT * FROM tutors_tbl WHERE password='" + txtPassword.Text.Trim() + "' And email='" + txtEmail.Text.Trim() + "' and accountStatusId='" + accoutnType + "'";
					SqlCommand cmd = new SqlCommand(query, con);
					SqlDataReader rdr = cmd.ExecuteReader();
					if (rdr.HasRows)
					{
						while (rdr.Read())
						{
							Response.Write("<script>alert('Login Successful');</script>");
							Session["name"] = rdr.GetValue(1).ToString();
							Session["role"] = "tutor";

						}
						Response.Redirect("homePage.aspx");
					}
					else
					{
						Response.Write("<script>alert('Invalid Credentials');</script>");

					}


					con.Close();
				}
				catch (Exception ex)
				{
					Response.Write("<script>alert('" + ex.Message + "');</script>");

				}

			}
			else
			{
				Response.Write("<script>alert('Pleass Select Account Type');</script>");

			}

		}

		void accountTypeStatus()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "select * from accountType_tbl WHERE id BETWEEN 1 AND 3 ";
				SqlCommand cmd = new SqlCommand(query, con);
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adp.Fill(dt);
				ddlAccountType.DataSource = dt;
				ddlAccountType.DataTextField = "accountStatus";
				ddlAccountType.DataValueField = "id";
				ddlAccountType.DataBind();
				ddlAccountType.Items.Insert(0, new ListItem("--Select Account Status--", "0"));
			}
			catch (Exception ex)
			{
				Response.Write("<script>alert('"+ex.Message+"');</script>");

			}
		}

		void clearTextBox()
		{
			ddlAccountType.Text = null;
			txtEmail.Text = null;
			txtPassword.Text = null;
		}
	}
}