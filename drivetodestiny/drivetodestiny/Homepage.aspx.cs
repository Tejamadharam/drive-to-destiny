using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drivetodestiny
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int i = ran.Next(1, 4);
            Image1.ImageUrl = "~/images/" + i.ToString() + ".jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}