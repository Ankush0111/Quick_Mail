using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gmail_clone
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null && Session["Name"].ToString() != "")
            {
                Label1.Text = Session["Email"].ToString();

                //Label2.Text = Session["Email"].ToString(); //+ "<br/>" + Session["mob"].ToString();

                Image1.ImageUrl = Session["img"].ToString();
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet x = Class1.fetch("select * from user_det where Email='" + TextBox5.Text + "'");

            if (x.Tables[0].Rows.Count != 0)
            {
                Session["img1"] = x.Tables[0].Rows[0][3].ToString();

                string myemail = null; // Initialize myemail with a default value (e.g., null)

                if (Session["Email"] != null)
                {
                    myemail = Session["Email"].ToString();
                }
                else
                {
                    // Handle the case where Session["Email"] is null or not set
                    // You can log an error, display a message to the user, or take appropriate action.
                    // For now, I'll just display an error message.
                    Response.Write("<script>alert('Session[\"Email\"] is null or not set.')</script>");
                    return; // Exit the method since myemail is not set
                }

               /* DataSet p = Class1.fetch("select max(msg_id) from massage");
                int msgId = 1;// Default value if there are no records in the Message table

                if (p.Tables[0].Rows.Count != 0 && p.Tables[0].Rows[0][0] != "")
                {
                    msgId = Convert.ToInt32(p.Tables[0].Rows[0][0]) + 1;
                }*/




                DataSet p = Class1.fetch("select max(msg_Id) from massage");
                int msgId = 1;

                if (p.Tables[0].Rows.Count != 0 && !p.Tables[0].Rows[0].IsNull(0))
                {
                    msgId = Convert.ToInt32(p.Tables[0].Rows[0][0]) + 1;
                }



                if (FileUpload1.HasFile == true)
                {
                    string filename = FileUpload1.FileName;
                    string ex = Path.GetExtension(filename);

                    if (ex != ".exe")
                    {
                        string imgurl = "~/pics/" + filename;


                        bool r = Class1.save("insert into massage(msg_Id,to_email,my_email,to_imgurl,my_imgurl,cc_email,title,body,att_url,dt) values( '" + msgId + "', '" + TextBox5.Text + "', '" + myemail + "', '" + Session["img1"].ToString() + "', '" + Image1.ImageUrl + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + imgurl + "', '" + System.DateTime.Now.ToLongDateString() + "')");

                        // Response.Write("<script>alert('save execute')</script>");

                        TextBox3.Text = r.ToString();
                        if (r == true)
                        {
                            Response.Write("<script>alert('SUCCESSFULLY Sent')</script>");
                            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/pics/") + filename);
                           // FileUpload1.PostedFile.SaveAs(Server.MapPath("~/pics/"));
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox5.Text = "";
                        }
                    }
                    else
                    {
                        // Handle the case where the uploaded file has an invalid extension (e.g., .exe)
                        Response.Write("<script>alert('Invalid file extension')</script>");
                    }
                }
                else
                {
                    // Handle the case where no file is uploaded
                    // You can display a message to the user or take other appropriate action.

                    bool r = Class1.save("insert into massage(msg_Id,to_email,my_email,to_imgurl,my_imgurl,cc_email,title,body,dt) values( '" + msgId + "', '" + TextBox5.Text + "', '" + myemail + "', '" + Session["img1"].ToString() + "', '" + Image1.ImageUrl + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + System.DateTime.Now.ToLongDateString() + "')");

                    TextBox3.Text = r.ToString();
                    if (r == true)
                    {
                        Response.Write("<script>alert('SUCCESSFULLY')</script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox5.Text = "";
                    }
                }
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet q = Class1.fetch("select * from user_det where Email='" + TextBox5.Text + "'");

            if (q.Tables[0].Rows.Count != 0)
            {
                Session["img1"] = q.Tables[0].Rows[0][3].ToString();

                // Response.Write("<script>alert('img get')</script>");

                string myemail = null; // Initialize myemail with a default value (e.g., null)

                if (Session["Email"] != null)
                {
                    myemail = Session["Email"].ToString();
                }
                else
                {
                    // Handle the case where Session["my_email"] is null or not set
                    // You can log an error, display a message to the user, or take appropriate action.
                    // For now, I'll just display an error message.
                    Response.Write("<script>alert('Session[\"my_email\"] is null or not set.')</script>");
                    return; // Exit the method since myemail is not set
                }

                DataSet p = Class1.fetch("select max(msg_Id) from massage");
                int msgId;// Default value if there are no records in the Draft table

                if (p.Tables[0].Rows.Count != 0 && p.Tables[0].Rows[0][0] != DBNull.Value)
                {
                    msgId = Convert.ToInt32(p.Tables[0].Rows[0][0]) + 1;
                }
                else
                {
                    msgId = 1;
                }


                if (FileUpload1.HasFile)
                {
                    string filename = FileUpload1.FileName;
                    string ex = Path.GetExtension(filename);

                    if (ex != ".exe")
                    {
                        string imgurl = "~/pics/" + filename;

                        bool r = Class1.save("insert into draft(msg_id,to_email,my_email,to_imgurl,my_imgurl,cc_email,title,body,att_url,dt) values( '" + msgId + "', '" + TextBox5.Text + "', '" + myemail + "', '" + Session["img1"].ToString() + "', '" + Image1.ImageUrl + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + imgurl + "', '" + System.DateTime.Now.ToLongDateString() + "')");

                        TextBox3.Text = r.ToString();
                        if (r == true)
                        {
                            Response.Write("<script>alert('Draft saved successfully')</script>");
                            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/pics/") + filename);
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox5.Text = "";
                        }
                        else
                        {
                            // Handle the case where the database insert operation fails
                            Response.Write("<script>alert('Failed to save the draft to the database')</script>");
                        }
                    }
                    else
                    {
                        // Handle the case where the uploaded file has an invalid extension (e.g., .exe)
                        Response.Write("<script>alert('Invalid file extension')</script>");
                    }
                }
                else
                {
                    // Handle the case where no file is uploaded
                    // You can display a message to the user or take other appropriate action.

                    bool r = Class1.save("insert into draft(msg_id,to_email,my_email,to_imgurl,my_imgurl,cc_email,title,body,dt) values( '" + msgId + "', '" + TextBox5.Text + "', '" + myemail + "', '" + Session["img1"].ToString() + "', '" + Image1.ImageUrl + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + System.DateTime.Now.ToLongDateString() + "')");

                    TextBox3.Text = r.ToString();
                    if (r)
                    {
                        Response.Write("<script>alert('Draft saved successfully')</script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox5.Text = "";
                    }
                    else
                    {
                        // Handle the case where the database insert operation fails
                        Response.Write("<script>alert('Failed to save the draft to the database')</script>");
                    }
                }
            }
            else
            {
                // Handle the case where no user with the specified email is found
                Response.Write("<script>alert('User with email '" + TextBox5.Text + "' not found')</script>");
            }
        }

        protected void ImageButton4_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/settings.aspx");
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}
