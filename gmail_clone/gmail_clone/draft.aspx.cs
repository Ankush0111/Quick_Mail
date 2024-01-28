using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gmail_clone
{
    public partial class draft : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            layers.Visible = false;
            outers.Visible = false;
            inners.Visible = false;
            if (Session["name"] != null && Session["name"].ToString() != "")
            {


                Label2.Text = Session["email"].ToString();

                Image1.ImageUrl = Session["img"].ToString();


            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
            DataSet ds = Class1.fetch("select * from draft where my_email='" + Session["email"].ToString() + "'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            if (Request.QueryString["msgid"] != null)
            {
                DataSet x = Class1.fetch("select * from draft where msg_id='" + Request.QueryString["msg_Id"] + "'");
                if (x.Tables[0].Rows.Count != null)
                {
                    Session["msg_Id"] = x.Tables[0].Rows[0][0].ToString();
                    Session["toemail"] = x.Tables[0].Rows[0][1].ToString();
                    Session["myemail"] = x.Tables[0].Rows[0][2].ToString();
                    Session["toimgurl"] = x.Tables[0].Rows[0][3].ToString();
                    Session["myimgurl"] = x.Tables[0].Rows[0][4].ToString();
                    Session["title"] = x.Tables[0].Rows[0][6].ToString();
                    Session["body"] = x.Tables[0].Rows[0][7].ToString();
                    Session["atturl"] = x.Tables[0].Rows[0][8].ToString();
                    Session["dt"] = x.Tables[0].Rows[0][9].ToString();
                    Session["cc"] = x.Tables[0].Rows[0][5].ToString();
                    layerc1.Visible = true;
                    outerc1.Visible = true;
                    innerc1.Visible = true;
                    Label4.Text = Session["dt"].ToString();
                    Label6.Text = Session["toemail"].ToString();
                    Label7.Text = Session["myemail"].ToString();
                    Label11.Text = Session["title"].ToString();
                    TextBox5.Text = Session["body"].ToString();
                    HyperLink1.NavigateUrl = Session["atturl"].ToString();
                }
            }
            else
            {
                layerc1.Visible = false;
                outerc1.Visible = false;
                innerc1.Visible = false;
            }

        }
        protected void dispImg()
        {
            DataSet dx = Class1.fetch("select * from user_det where id!='" + Session["id"] + "'");
            if (dx.Tables[0].Rows.Count != 0)
            {
                //DataList1.DataSource = dx;
                //DataList1.DataBind();
            }
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/inbox.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/sent.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            string myemail = Session["email"].ToString();
            DataSet x = Class1.fetch("select * from msg1 where my_email='" + Session["email"].ToString() + "'");
            if (x.Tables[0].Rows.Count != 0)
            {
                Session["id"] = x.Tables[0].Rows[0][0].ToString();
                Session["to_email"] = x.Tables[0].Rows[0][1].ToString();
                Session["my_email"] = x.Tables[0].Rows[0][2].ToString();
                Session["to_imgurl"] = x.Tables[0].Rows[0][3].ToString();
                Response.Redirect("~/draft.aspx?" + Session["id"].ToString());
            }
            else
            {
                Response.Redirect("~/draft.aspx");

            }
        }

        protected void ImageButton4_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/settings.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}