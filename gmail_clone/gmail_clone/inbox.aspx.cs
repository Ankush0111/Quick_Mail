﻿/*using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gmail_clone
{
    public partial class inbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            layers.Visible = false;
            outers.Visible = false;
            inners.Visible = false;

            if (Session["name"] != null && !string.IsNullOrEmpty(Session["name"].ToString()) &&
                 Session["email"] != null && !string.IsNullOrEmpty(Session["email"].ToString()))
            {

                Label2.Text = Session["email"].ToString();
                Image1.ImageUrl = Session["img"].ToString();


                DataSet ds = Class1.fetch("select * from massage"); //where to_email='" + Session["to_email"].ToString() + "'");
                Console.WriteLine("Test1");
                if (ds.Tables[0].Rows.Count != 0)
                {
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    Console.WriteLine("Test2");
                }


                if (Request.QueryString["msg_Id"] != null)
                {

                    DataSet x = Class1.fetch("select * from massage where msg_Id='" + Request.QueryString["msg_Id"] + "'");
                    if (x.Tables[0].Rows.Count != 0)
                    {

                        Session["msg_id"] = x.Tables[0].Rows[0][0].ToString();
                        Session["to_email"] = x.Tables[0].Rows[0][1].ToString();
                        Session["my_email"] = x.Tables[0].Rows[0][2].ToString();
                        Session["to_imgurl"] = x.Tables[0].Rows[0][3].ToString();
                        Session["my_imgurl"] = x.Tables[0].Rows[0][4].ToString();
                        Session["cc_email"] = x.Tables[0].Rows[0][5].ToString();
                        Session["title"] = x.Tables[0].Rows[0][6].ToString();
                        Session["body"] = x.Tables[0].Rows[0][7].ToString();
                        Session["att_url"] = x.Tables[0].Rows[0][8].ToString();
                        Session["dt"] = x.Tables[0].Rows[0][9].ToString();


                        layers.Visible = true;
                        outers.Visible = true;
                        inners.Visible = true;
                        Label3.Text = Session["dt"].ToString();
                        Label5.Text = Session["my_email"].ToString();
                        Label6.Text = Session["to_email"].ToString();
                        Label11.Text = Session["title"].ToString();
                        TextBox5.Text = Session["body"].ToString();
                        HyperLink1.NavigateUrl = Session["att_url"].ToString();
                        Response.Redirect("~/inbox-content.aspx?" + Session["msg_Id"].ToString());
                    }
                }
                else
                {

                    layers.Visible = false;
                    outers.Visible = false;
                    inners.Visible = false;
                }
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }


        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            //string myemail = Session["email"].ToString();
            //DataSet x = Class1.fetch("select * from massage where my_email='" + Session["email"].ToString() + "'");
            //if (x.Tables[0].Rows.Count != 0)
            //{
            //    Session["id"] = x.Tables[0].Rows[0][0].ToString();
            //    Session["to_email"] = x.Tables[0].Rows[0][1].ToString();
            //    Session["my_email"] = x.Tables[0].Rows[0][2].ToString();
            //    Session["to_imgurl"] = x.Tables[0].Rows[0][3].ToString();
            //    Response.Redirect("~/Sent.aspx?" + Session["id"].ToString());
            //}
            //else
            //{
            //    Response.Redirect("~/sent.aspx");
            //}
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/inbox.aspx");
        }
        protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/sent.aspx");
        }

        protected void ImageButton3_Click1(object sender, ImageClickEventArgs e)
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

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Reflection.Emit;

namespace gmail_clone
{
    public partial class inbox : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["name"] != null && Session["name"].ToString() != "")
            {

                Label2.Text = Session["email"].ToString();

                Image1.ImageUrl = Session["img"].ToString();


            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }

            DataSet ds = Class1.fetch("select * from massage where to_email='" + Session["email"].ToString() + "'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            if (Request.QueryString["msg_Id"] != null)
            {
                DataSet x = Class1.fetch("select * from massage where msg_Id='" + Request.QueryString["msg_Id"] + "'");
                if (x.Tables[0].Rows.Count != 0)
                {
                    Session["msg_Id"] = x.Tables[0].Rows[0][0].ToString();
                    Session["to_email"] = x.Tables[0].Rows[0][1].ToString();
                    Session["my_email"] = x.Tables[0].Rows[0][2].ToString();
                    Session["to_imgurl"] = x.Tables[0].Rows[0][3].ToString();
                    Session["my_imgurl"] = x.Tables[0].Rows[0][4].ToString();
                    Session["cc_email"] = x.Tables[0].Rows[0][5].ToString();
                    Session["title"] = x.Tables[0].Rows[0][6].ToString();
                    Session["body"] = x.Tables[0].Rows[0][7].ToString();
                    Session["att url"] = x.Tables[0].Rows[0][8].ToString();
                    Session["dt"] = x.Tables[0].Rows[0][9].ToString();

                    Label3.Text = Session["dt"].ToString();
                    Label5.Text = Session["my_email"].ToString();
                    Label6.Text = Session["to_email"].ToString();
                    Label11.Text = Session["title"].ToString();
                    TextBox5.Text = Session["body"].ToString();
                    HyperLink1.NavigateUrl = Session["att_url"].ToString();
                    Response.Redirect("~/inbox-content.aspx?" + Session["msg_Id"].ToString());
                }

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
            Response.Redirect("~/draft.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/settings.aspx");
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}