using System;
using System.Web.UI;

namespace SystemWebAdaptersRedirect
{
    public partial class Redirect : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("~/Test.aspx");
        }
    }
}