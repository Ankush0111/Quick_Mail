using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gmail_clone
{
    public partial class Default : System.Web.UI.Page
    {
        bool i;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile == true)
            {
                Response.Write("<script>alert('" + "enter in if" + "') </Script>");
                string filename = FileUpload1.FileName;
                string size = FileUpload1.PostedFile.ContentLength.ToString();
                string ex = Path.GetExtension(filename);

                if (ex == ".jpg" || ex == ".jpeg" || ex == ".png")
                {
                    string imgurl = "~/emailpics/" + filename;
                    bool r = Class1.save("insert into user_det(Name,Email,Password,Img) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + imgurl + "')");
                    if (r == true)
                    {
                        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/emailpics/") + filename);
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";

                    }
                    Response.Redirect("~/login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('profile image can not be emptys')</script>");
                }
            }

        }
    }
}