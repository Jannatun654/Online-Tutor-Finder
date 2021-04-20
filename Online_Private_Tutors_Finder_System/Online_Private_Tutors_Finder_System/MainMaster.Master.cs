using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Private_Tutors_Finder_System
{
	public partial class MainMaster : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			if (!IsPostBack)
			{
				try
				{
					if (Session["role"] == null)
					{
						linkWelcomePage.Visible = true;
						linkHomePage.Visible = false;
						linkAboutPage.Visible = true;
						linkContactusPage.Visible = true;
						linkregisterPage.Visible = true;
						linkloginPage.Visible = true;

						linklogout.Visible = false;
						linkHelloUser.Visible = false;
						linkAdminDashboardPagg.Visible = false;
						linkAddAStudentPage.Visible = false;
						linkStudentManagementPage.Visible = false;
						linkAddATutor.Visible = false;
						LinkTutorPage.Visible = false;
						linkAddAParentPagg.Visible = false;
						linkParentManagementPage.Visible = false;
						linlGetAllInquirisPage.Visible = false;						
						linkParentDashBoardPage.Visible = false;
						linkReserveATutorPage.Visible = false;
						linkRateTutorAddPage.Visible = false;
						linkViewTutorRequistListPage.Visible = false;
						linkTitorDashboardPage.Visible = false;
						linkReservationPage.Visible = false;
						linkViewRatingPage.Visible = false;
					}
					else if (Session["role"].Equals("parent"))
					{
						linkWelcomePage.Visible = false;
						linkHomePage.Visible = true;
						linkAboutPage.Visible = true;
						linkContactusPage.Visible = true;
						linkregisterPage.Visible = false;
						linkloginPage.Visible = false;

						linklogout.Visible = true;
						linkHelloUser.Visible = true;
						linkHelloUser.Text = Convert.ToString(Session["name"]);

						linkAdminDashboardPagg.Visible = false;
						linkAddAStudentPage.Visible = false;
						linkStudentManagementPage.Visible = false;
						linkAddATutor.Visible = false;
						LinkTutorPage.Visible = false;
						linkAddAParentPagg.Visible = false;
						linkParentManagementPage.Visible = false;
						linlGetAllInquirisPage.Visible = false;
						linkParentDashBoardPage.Visible = true;
						linkReserveATutorPage.Visible = true;
						linkRateTutorAddPage.Visible = true;
						linkViewTutorRequistListPage.Visible = true;
						linkTitorDashboardPage.Visible = false;
						linkReservationPage.Visible = false;
						linkViewRatingPage.Visible = false;
					}
					else if (Session["role"].Equals("tutor"))
					{
						linkWelcomePage.Visible = false;
						linkHomePage.Visible = true;
						linkAboutPage.Visible = true;
						linkContactusPage.Visible = true;
						linkregisterPage.Visible = false;
						linkloginPage.Visible = false;
						linklogout.Visible = true;
						linkHelloUser.Visible = true;
						linkHelloUser.Text = Convert.ToString(Session["name"]);
						linkAdminDashboardPagg.Visible = false;
						linkAddAStudentPage.Visible = false;
						linkStudentManagementPage.Visible = false;
						linkAddATutor.Visible = false;
						LinkTutorPage.Visible = false;
						linkAddAParentPagg.Visible = false;
						linkParentManagementPage.Visible = false;
						linlGetAllInquirisPage.Visible = false;
						linkParentDashBoardPage.Visible = false;
						linkReserveATutorPage.Visible = false;
						linkViewTutorRequistListPage.Visible = true;
						linkRateTutorAddPage.Visible = false;
						linkTitorDashboardPage.Visible = true;
						linkReservationPage.Visible = true;
						linkViewRatingPage.Visible = true;
					}
					else if (Session["role"].Equals("admin"))
					{
						linkWelcomePage.Visible = false;
						linkHomePage.Visible = true;
						linkAboutPage.Visible = true;
						linkContactusPage.Visible = true;
						linkregisterPage.Visible = false;
						linkloginPage.Visible = false;

						linklogout.Visible = true;
						linkHelloUser.Visible = true;
						linkHelloUser.Text = Convert.ToString(Session["name"]);

						linkAdminDashboardPagg.Visible = true;
						linkAddAStudentPage.Visible = true;
						linkStudentManagementPage.Visible = true;
						linkAddATutor.Visible = true;
						LinkTutorPage.Visible = true;
						linkAddAParentPagg.Visible = true;
						linkParentManagementPage.Visible = true;
						linlGetAllInquirisPage.Visible = true;
						linkParentDashBoardPage.Visible = false;
						linkReserveATutorPage.Visible = false;
						linkRateTutorAddPage.Visible = false;
						linkViewTutorRequistListPage.Visible = false;
						linkTitorDashboardPage.Visible = false;
						linkReservationPage.Visible = false;
						linkViewRatingPage.Visible = false;
					}
				}
				catch (Exception ex)
				{
					Response.Write("<script>alert('" + ex.Message + "');</script>");

				}
			}

		}

		protected void linklogout_Click(object sender, EventArgs e)
		{
			Session["name"] = "";
			Session["role"] = "";
			linkWelcomePage.Visible = true;
			linkHomePage.Visible = false;
			linkAboutPage.Visible = true;
			linkContactusPage.Visible = true;
			linkregisterPage.Visible = true;
			linkloginPage.Visible = true;

			linklogout.Visible = false;
			linkHelloUser.Visible = false;
			linkAdminDashboardPagg.Visible = false;
			linkAddAStudentPage.Visible = false;
			linkStudentManagementPage.Visible = false;
			linkAddATutor.Visible = false;
			LinkTutorPage.Visible = false;
			linkAddAParentPagg.Visible = false;
			linkParentManagementPage.Visible = false;
			linlGetAllInquirisPage.Visible = false;
			linkParentDashBoardPage.Visible = false;
			linkReserveATutorPage.Visible = false;
			linkRateTutorAddPage.Visible = false;
			linkViewTutorRequistListPage.Visible = false;
			linkTitorDashboardPage.Visible = false;
			linkReservationPage.Visible = false;
			linkViewRatingPage.Visible = false;
			Response.Redirect("DefultPage.aspx");
			
		}
	}
}