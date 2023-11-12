using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;

namespace A6
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string directoryPath = HttpContext.Current.Server.MapPath("~/App_Data/Accounts.xml");
            XPathDocument dx = new XPathDocument(directoryPath);
            XPathNavigator nav = dx.CreateNavigator();

            XPathNodeIterator iterator = nav.Select("/Accounts/Account");
            while (iterator.MoveNext())
            {
                String user;
                XPathNodeIterator it = iterator.Current.Select("Username");
                it.MoveNext();
                string courseName = it.Current.Value;
                it = iterator.Current.Select("Password");
                it.MoveNext();
                string courseCode = it.Current.Value;
                Console.WriteLine("{0} {1}", courseName, courseCode);
                Label1.Text += courseName;
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }
    }
}