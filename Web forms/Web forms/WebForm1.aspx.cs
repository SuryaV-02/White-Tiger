using System;
using System.Web.UI.WebControls;


namespace Web_forms
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 WebServiceObj;
        static bool isFormValid = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            WebServiceObj = new WebService1();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (isFormValid)
            {
                int num1 = Convert.ToInt32(TbNum1.Text);
                int num2 = Convert.ToInt32(TbNum2.Text);
                int result = WebServiceObj.Add(num1, num2);
                LabRes.Text = Convert.ToString(result);
            }
            
        }

        protected void ValidateGoodNumber(object sender, ServerValidateEventArgs ev)
        {
            int value = Convert.ToInt32(ev.Value);
            if (value > 0 && value <= 9)
            {
                ev.IsValid = true;
                isFormValid = true;
            }else
            {
                ev.IsValid = false;
                isFormValid = false;
            }
        }
        
    }
}