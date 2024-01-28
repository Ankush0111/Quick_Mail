using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gmail_clone
{
    public partial class settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null && Session["Name"].ToString() != "")
            {
                Label2.Text = Session["Email"].ToString();

                //Label2.Text = Session["Email"].ToString(); //+ "<br/>" + Session["mob"].ToString();

                Image1.ImageUrl = Session["img"].ToString();
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string filename = FileUpload1.FileName;
            string ex = Path.GetExtension(FileUpload1.FileName).ToLower();

            Response.Write("<script>alert('" + ex + "')</script>");

            if (ex == ".jpg" || ex == ".jpeg" || ex == ".png")
            {




                string imgurl = "~/emailpics/" + filename;
                string imgurl1 = "~/pics/" + filename;
                Image2.ImageUrl = imgurl.ToString();
                bool r = Class1.save("update user_det set Name='" + TextBox8.Text + "',Password='" + TextBox9.Text + "',img='" + imgurl + "' where Email='" + Session["email"].ToString() + "'");





                if (r == true)
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/emailpics/") + filename);
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/pics/") + filename);
                    Response.Write("<script>alert('Changes Successfully')</script>");
                    Response.Redirect("~/login.aspx");
                }
                else
                {
                    TextBox8.Text = "";

                    Response.Write("<script>alert('Changes not saved')</script>");
                }
            }
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
    }
}
