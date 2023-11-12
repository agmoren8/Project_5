using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A6
{
    public partial class myGlobal : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String semester, year;
            semester = "fourth semester";
            year = "2023";



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //creates an object of addPark
            WordFilter.Service1Client wordFilter = new WordFilter.Service1Client();
            TextBox2.Text = wordFilter.WordFilter(TextBox1.Text);
        }
    }
}