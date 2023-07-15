using System;
using System.Web;
using System.Web.UI;
namespace HRManagement.Views
{

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /*
        public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked me";
        }*/

        public void SignInButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("In form");
            string email = Request.Form["email"];
            string password = Request.Form["password"];
            Console.WriteLine("Email :" + email);
            Console.WriteLine("Password :" + password);
            ErrorLabel.Text = "Your username or password is incorrect";
            ErrorLabel.ForeColor = System.Drawing.Color.Red;
        }
    }
}
