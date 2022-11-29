using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MicroService.Addition;

namespace MicroService
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        private WebService1 obj;

        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new WebService1();
        }

        public void SubmitButton(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt1.Text);
            int b = Convert.ToInt32(txt2.Text);

            string res = obj.add(a, b);
            Console.WriteLine(res);
            result.Text = res;
        }


    }
}
