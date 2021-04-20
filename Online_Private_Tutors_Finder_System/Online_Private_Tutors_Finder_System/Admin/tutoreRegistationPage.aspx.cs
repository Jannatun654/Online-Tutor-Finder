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

namespace Online_Private_Tutors_Finder_System.Admin
{
	public partial class tutoreRegistationPage : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString;

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void TutorsRegister_Click(object sender, EventArgs e)
		{
			if (cheackTutorEmail())
			{
				Response.Write("<script>alert('Sorry!!!Tutore Email Already Exits Pleass Try another Tutore Email.....');</script>");
			}
			else
			{
				createNewTutor();
			}

		}


		bool cheackTutorEmail()
		{
			try
			{
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "select * from tutors_tbl where email='" + txtTEmail.Text.Trim() + "'";
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


		public void createNewTutor()
		{
			try
			{
				
				string path = Path.GetFileName(uploadVideo.FileName);
				path = path.Replace(" ", "");
				uploadVideo.SaveAs(Server.MapPath("/video/" + path));


					string fileNamePic = Path.GetFileName(uploadPicture.PostedFile.FileName);
					uploadPicture.SaveAs(Server.MapPath("~/img/" + fileNamePic));
					string filePic = "~/img/" + fileNamePic;

					SqlConnection con = new SqlConnection(strcon);
					con.Open();
					string query = "INSERT INTO tutors_tbl (name,universityName,departmentName,subjectName,address,username,email,password,ImageLink,demoVideoLink,accountStatusId) VALUES(@name,@universityName,@departmentName,@subjectName,@address,@username,@email,@password,@ImageLink,@demoVideoLink,@accountStatusId)";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@name", txtTName.Text.Trim());
					cmd.Parameters.AddWithValue("@universityName", txtUniversityName.Text.Trim());
					cmd.Parameters.AddWithValue("@departmentName", txtDepartmentName.Text.Trim());
					cmd.Parameters.AddWithValue("@subjectName", txtSubjectName.Text.Trim());
					cmd.Parameters.AddWithValue("@username", txtTUsername.Text.Trim());
					cmd.Parameters.AddWithValue("@email", txtTEmail.Text.Trim());
					cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
					cmd.Parameters.AddWithValue("@password", txtTPassword.Text.Trim());
					cmd.Parameters.AddWithValue("@ImageLink", filePic);
					cmd.Parameters.AddWithValue("@demoVideoLink", "/Video/" + path);
					cmd.Parameters.AddWithValue("@accountStatusId", "3");
					cmd.ExecuteNonQuery();
					con.Close();
					Response.Write("<script>alert('Successfully Added Tutore ');</script>");
					ClearTextBox();


			}
			catch (Exception ex)
			{
				Response.Write("<script>alert('" + ex.Message + "');</script>");

			}
		}
		public void ClearTextBox()
		{
			txtTName.Text = null;
			txtTUsername.Text = null;
			txtTEmail.Text = null;
			txtAddress.Text = null;
			txtTPassword.Text = null;
			txtUniversityName.Text = null;
			txtDepartmentName.Text = null;
			txtSubjectName.Text = null;


		}

	}
}