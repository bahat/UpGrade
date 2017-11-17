using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginAccount(object sender, EventArgs e)
    {
        //    string connectionstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Users.mdf;Integrated Security=True";
        //    SqlConnection c = new SqlConnection(connectionstr);
        //    SqlCommand cmd;
        //    cmd = new SqlCommand("SELECT Password FROM [@SelectedTable] WHERE Username = @Username AND School = @School", c);
        //    string password;
        //    //try
        //    //{
        //        c.Open();
        //        cmd.Parameters.AddWithValue("SelectedTable", TeacherOrStudent.SelectedValue);
        //        cmd.Parameters.AddWithValue("Username", UserName.Text);
        //        cmd.Parameters.AddWithValue("School", SchoolName.Text);
        //        password = cmd.ExecuteReader().GetString(0);
        //        if (password.Equals(Password.Text))
        //            Response.Redirect("http://www.google.com");

        //    //}
        //    //catch
        //    //{
        //    //    Response.Redirect("http://www.bing.com");
        //    //}
    }
}