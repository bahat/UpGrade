using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminPages_AddStudents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Insert_Click(object sender, EventArgs e)
    {
        int id = 0;
        SqlConnection c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Omer\\Dropbox\\school\\UpGradeProject\\DepartmentOfEducation\\App_Data\\Students.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand("INSERT INTO Students (DOB, FirstName, LastName, SchoolID, PhoneNumber, MailAddress) VALUES(@DOB, @FirstName, @LastName, @SchoolID, @PhoneNumber, @MailAddress); SELECT StudentId From Students WHERE StudentId = SCOPE_IDENTITY()", c);
        cmd.Parameters.AddWithValue("FirstName", FirstName.Text);
        cmd.Parameters.AddWithValue("LastName", LastName.Text);
        cmd.Parameters.AddWithValue("PhoneNumber", PhoneNumber.Text);
        cmd.Parameters.AddWithValue("MailAddress", MailAddress.Text);
        cmd.Parameters.AddWithValue("SchoolID", SchoolID.Text);
        cmd.Parameters.AddWithValue("DOB", Convert.ToDateTime(DOB.Text));

        try
        {
            c.Open();
            id = (int)cmd.ExecuteScalar();
            Response.Write("<script>alert('Created');</script>");

        }
        catch
        {
            Response.Write("<script>alert('Failed');</script>");

        }
        c.Close();
        c.Open();
        SqlCommand cmd1 = new SqlCommand("UPDATE Students SET Password = @id WHERE StudentId = @id", c);
        cmd1.Parameters.AddWithValue("id", id);
        cmd1.ExecuteNonQuery();
        c.Close();


    }

}