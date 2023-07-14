using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("/files/" + Session.SessionID + getString() + "." + Path.GetExtension
               (FileUpload1.PostedFile.FileName));
            FileUpload1.SaveAs(path);
        }
        string getString()
        {
            string str = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
            str =str.Substring(0, str.Length - 2);
            return str;

        }
    }
}