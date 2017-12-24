using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginAccount(object sender, EventArgs e)
    {
        if (validateAccount())
        {
            loginSession();
            Page.Response.Redirect("~/Home.aspx", true);
        }
        else
        {
            string str = "Wrong Username/Password, try again or reset password.";
            Response.Write("<script>alert('"+str+"');</script>");
        }
        
    }


    protected void loginSession()
    {
        string connectionstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Omer\\Dropbox\\school\\UpGradeProject\\DepartmentOfEducation\\App_Data\\Students.mdf;Integrated Security=True";
        SqlConnection c = new SqlConnection(connectionstr);
        SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE StudentId = @id", c);
        cmd.Parameters.AddWithValue("id", int.Parse(UserName.Text));
        c.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Session["FirstName"] = reader["FirstName"].ToString();
            Session["LastName"] = reader["LastName"].ToString();
            Session["SchoolID"] = reader["SchoolID"].ToString();
            Session["StudentId"] = reader["StudentId"].ToString();
            Session["DOB"] = reader["DOB"].ToString();
            Session["PhoneNumber"] = reader["PhoneNumber"].ToString();
            Session["MailAddress"] = reader["MailAddress"].ToString();
        }
        c.Close();
    }

    protected void forgotPass(object sender, EventArgs e)
    {
        PassReset.DepartmentOfEducation client = new PassReset.DepartmentOfEducation();
        string str = client.SendIt(UserName.Text);
        Response.Write("<script>alert('"+str+"');</script>");
        
    }

    protected bool validateAccount()
    {
        try
        {
            string connectionstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Omer\\Dropbox\\school\\UpGradeProject\\DepartmentOfEducation\\App_Data\\Students.mdf;Integrated Security=True";
            SqlConnection c = new SqlConnection(connectionstr);
            SqlCommand cmd = new SqlCommand("SELECT Password FROM Students WHERE StudentId = @id", c);
            cmd.Parameters.AddWithValue("id", int.Parse(UserName.Text));
            c.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string pass = reader["Password"].ToString();
            return pass == Password.Text;
        }
        catch
        {
            return false;
        }
            

    }

}

//LOGINACCOUNTFIRSTTRYLOG
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