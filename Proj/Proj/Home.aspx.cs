using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void patientLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientLogin.aspx");
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            
        }
    }
}