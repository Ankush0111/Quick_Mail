using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gmail_clone
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet x = Class1.fetch("select * from user_det where email='" + TextBox1.Text + "'");
            if (x.Tables[0].Rows.Count != 0)
            {

                if (x.Tables[0].Rows[0][2].ToString() == TextBox3.Text)
                {
                    Session["Name"] = x.Tables[0].Rows[0][0].ToString();// + " " + x.Tables[0].Rows[0][2].ToString();
                    Session["Email"] = x.Tables[0].Rows[0][1].ToString();
                    Session["img"] = x.Tables[0].Rows[0][3].ToString();
                    Response.Redirect("~/Default2.aspx?" + Session["Email"].ToString());
                }
                else
                {
                    Response.Write("<script>alert('INVALID PASSWORD')</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('INVALID USER NAME')</script>");

            }
        }
    }
}