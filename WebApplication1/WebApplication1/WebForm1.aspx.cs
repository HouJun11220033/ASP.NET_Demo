using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  lblmessage.Text += "Page post back event handled.<br/>";
            
        }
        protected void Page_Init(object sender, EventArgs e)
        {
          //  lblmessage.Text += "Page initialization event handled.<br/>";
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            //   lblmessage.Text += "Page prerender event handled. <br/>";
        }

        protected void btnclick_Click(object sender, EventArgs e)
        {
          //  lblmessage.Text += "Button click event handled. <br/>";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBox1.Text))
            {
              //  Label1.Text = "Welcome," + Server.HtmlEncode(TextBox1.Text) + "<br/> The URL is" + Server.UrlEncode(Request.UserHostAddress);
                Label1.Text = "Welcome," + TextBox1.Text + "<br/> The URL is" + Request.UserHostName;
            }
        }
    }
}