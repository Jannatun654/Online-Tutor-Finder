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
	public partial class contactusPage : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnContactSubmit_Click(object sender, EventArgs e)
		{
			// Contact Us Button Is Click
			try {
				SqlConnection con = new SqlConnection(strcon);
				con.Open();
				string query = "INSERT INTO contactus_tbl (name, email, phone,subject,message) VALUES(@name, @email, @phone,@subject,@message); ";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@name", txtContactName.Text.Trim());
				cmd.Parameters.AddWithValue("@email", txtContactEmail.Text.Trim());
				cmd.Parameters.AddWithValue("@phone", txtContactPhone.Text.Trim());
				cmd.Parameters.AddWithValue("@subject", txtContactSubject.Text.Trim());
				cmd.Parameters.AddWithValue("@message", txtContactMessage.Text.Trim());
				cmd.ExecuteNonQuery();
				con.Close();
				Response.Write("<script>alert('Successfully Send Your Message ');</script>");
				clearTextBox();
			}
			catch (Exception ex)
			{
				Response.Write("<script>alert('"+ex.Message +"');</script>");
			}

		}

		public void clearTextBox()
		{
			txtContactName.Text = null;
			txtContactEmail.Text = null;
			txtContactPhone.Text = null;
			txtContactSubject.Text = null;
			txtContactMessage.Text = null;
		}

	}
}