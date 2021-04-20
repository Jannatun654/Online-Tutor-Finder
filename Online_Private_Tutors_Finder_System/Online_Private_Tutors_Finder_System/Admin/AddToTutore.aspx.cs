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
	public partial class AddToTutore : System.Web.UI.Page
	{
		string strcon = ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				
				if (Session["buyitems"]== null)
				{
					btnAddTutore.Enabled = false;
				}
				else
				{
					btnAddTutore.Enabled = true;
				}

				Session["addtutore"] = "false";
				DataTable dt = new DataTable();
				DataRow dr;
				dt.Columns.Add("sno");
				dt.Columns.Add("tid");
				dt.Columns.Add("tname");
				dt.Columns.Add("imageurl");

				if (Request.QueryString["id"] !=null)
				{
					if (Session["buyitems"] == null)
					{
						dr = dt.NewRow();
						SqlConnection con = new SqlConnection(strcon);
						SqlDataAdapter da = new SqlDataAdapter("select * from tutors_tbl where id="+Request.QueryString["id"],con);
						DataSet ds = new DataSet();
						da.Fill(ds);
						dr["sno"] = 1;
						dr["tid"] = ds.Tables[0].Rows[0]["id"].ToString();
						dr["tname"]= ds.Tables[0].Rows[0]["name"].ToString();
						dr["imageurl"] = ds.Tables[0].Rows[0]["ImageLink"].ToString();
						dt.Rows.Add(dr);
						gridAddToTutior.DataSource = dt;
						gridAddToTutior.DataBind();
						Session["buyitems"] = dt;
						btnAddTutore.Enabled = true;
						
					}
					else
					{
						dt = (DataTable)Session["buyitems"];
						int sr;
						sr = dt.Rows.Count;
						dr = dt.NewRow();
						SqlConnection con = new SqlConnection(strcon);
						SqlDataAdapter da = new SqlDataAdapter("select * from tutors_tbl where id=" + Request.QueryString["id"], con);
						DataSet ds = new DataSet();
						da.Fill(ds);
						dr["sno"] =sr+1;
						dr["tid"] = ds.Tables[0].Rows[0]["id"].ToString();
						dr["tname"] = ds.Tables[0].Rows[0]["name"].ToString();
						dr["imageurl"] = ds.Tables[0].Rows[0]["ImageLink"].ToString();
						dt.Rows.Add(dr);
						gridAddToTutior.DataSource = dt;
						gridAddToTutior.DataBind();
						Session["buyitems"] = dt;
						btnAddTutore.Enabled = true;
						
					}
				}
				else
				{
					dt = (DataTable)Session["buyitems"];
					gridAddToTutior.DataSource = dt;
					gridAddToTutior.DataBind();
				}
			}
		}

		protected void btnAddTutore_Click(object sender, EventArgs e)
		{

			if (Session["role"].Equals("parent"))
			{
				string prentName = Convert.ToString(Session["name"]);
				string childId = Convert.ToString(Session["studentId"]);
				DataTable dt;
				dt = (DataTable)Session["buyitems"];
				for (int i = 0; i <= dt.Rows.Count - 1; i++)
				{
					SqlConnection con = new SqlConnection(strcon);
					con.Open();
					string query = "INSERT INTO tutoreBooking_tbl (tutoreName,tutoreId,prentName,childId,status,bookingDate) VALUES(@tutoreName,@tutoreId,@prentName,@childId,@status,@bookingDate)";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@tutoreName", dt.Rows[i]["tname"]);
					cmd.Parameters.AddWithValue("@tutoreId", dt.Rows[i]["tid"]);
					cmd.Parameters.AddWithValue("@prentName", prentName);
					cmd.Parameters.AddWithValue("@childId", childId);
					cmd.Parameters.AddWithValue("@status", "Requiest Pending");
					cmd.Parameters.AddWithValue("@bookingDate", DateTime.Now.ToShortDateString());
					cmd.ExecuteNonQuery();
					con.Close();
					Response.Write("<script>alert('Successfully Booking Tutore ');</script>");
					gridAddToTutior.DataSource = "";
					gridAddToTutior.DataBind();
					
				}
			}
			else
			{
				Response.Write("<script>alert('Pless Parents Login And Booking Tutore');</script>");
			}

		
		}
	}
}