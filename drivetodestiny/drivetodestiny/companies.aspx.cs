using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drivetodestiny
{
    public partial class companies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int i = ran.Next(1,7);
            Image1.ImageUrl = "~/images1/"+i.ToString()+".jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentdetails.aspx");
        }
    }
}