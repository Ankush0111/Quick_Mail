using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gmail_clone
{
    public partial class sent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null && Session["name"].ToString() != "")
            {

                Label2.Text = Session["email"].ToString();

                Image1.ImageUrl = Session["img"].ToString();
                /* layerc1.Visible = false;
                 outerc1.Visible = false;
                 innerc1.Visible = false;*/


            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
            DataSet ds = Class1.fetch("select * from massage where my_email='" + Session["email"].ToString() + "'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            if (Request.QueryString["msgid"] != null)
            {
                DataSet x = Class1.fetch("select * from massage where msg_Id='" + Request.QueryString["msgid"] + "'");
                if (x.Tables[0].Rows.Count != null)
                {
                    Session["msg_id"] = x.Tables[0].Rows[0][0].ToString();
                    Session["to_email"] = x.Tables[0].Rows[0][1].ToString();
                    Session["my_email"] = x.Tables[0].Rows[0][2].ToString();
                    Session["to_imgurl"] = x.Tables[0].Rows[0][3].ToString();
                    Session["my_imgurl"] = x.Tables[0].Rows[0][4].ToString();
                    Session["title"] = x.Tables[0].Rows[0][6].ToString();
                    Session["body"] = x.Tables[0].Rows[0][7].ToString();
                    Session["att_url"] = x.Tables[0].Rows[0][8].ToString();
                    Session["dt"] = x.Tables[0].Rows[0][9].ToString();

                }
            }
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/inbox.aspx");
        }

        protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/sent.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/draft.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/settings.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}