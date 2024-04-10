using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bro_code
{
    public partial class bro_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string name = TextBox1.Text;
            string email = TextBox2.Text;
            string message = TextBox3.Text;

            if (name == "" || email == "" || message == "")
            {
                Label1.Text = "Please Add all needed information.";
            }
            else
            {
                Label1.Text = "Thank you for your message " + name + " we will get back to you soon";
            }
        }
    }
}