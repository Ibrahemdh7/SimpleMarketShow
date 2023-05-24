using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace DatabaseUltraHomeWork
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            // Admin
            SqlCommand cmd4 = new SqlCommand("select*from UltraBoss where Email = @email and EnterWord = @pass", cnn);
            cmd4.Parameters.AddWithValue("@email",email);
            cmd4.Parameters.AddWithValue("@pass",password);
            cnn.Open();
            if (cmd4.ExecuteReader().HasRows)
            {
                Session["HighBoss"] = email;
                Response.Redirect("Admin.aspx");
                cnn.Close();
            }
            else
            {
                cnn.Close();
            }
            cnn.Open();
            if (cmd4.ExecuteReader().HasRows)
            {
                Session["HighBossPass"] = txtPassword.Text;
                Response.Redirect("Admin.aspx");
                cnn.Close();
            }
            // Dan Dan 

            // Manger
            cnn.Close();
            SqlCommand cmd5 = new SqlCommand("select*from UltraBoss where Email = @email and EnterWord = @pass", cnn);
            cmd5.Parameters.AddWithValue("@email", email);
            cmd5.Parameters.AddWithValue("@pass", password);
            cnn.Open();
            if (cmd5.ExecuteReader().HasRows)
            {
                Session["Boss"] = email;
                Response.Redirect("Manegar.aspx");
                cnn.Close();
            }
            else
            {
                cnn.Close();
            }
            cnn.Open();
            if (cmd4.ExecuteReader().HasRows)
            {
                Session["BossPass"] = txtPassword.Text;
                Response.Redirect("Manegar.aspx");
                cnn.Close();
            }



            //Dan Dan Dan Dan



            SqlCommand cmd = new SqlCommand("select*from Customers where Email = @email and password = @pass", cnn);
            cmd.Parameters.AddWithValue("@email",email );
            cmd.Parameters.AddWithValue("@pass", password);

            //SqlCommand cmd1 = new SqlCommand("select*from Customers where Firstname = @first and Lastname =@last and Email = @email", cnn);
            //cmd1.Parameters.AddWithValue("@first", name);
            //cmd1.Parameters.AddWithValue("@last", name2);
            //cmd1.Parameters.AddWithValue("@email", email);

            //SqlCommand cmd2 = new SqlCommand("select * from Customers where Firstname = @first and Lastname =@last", cnn);
            cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                Session["Name"] = rdr.GetString(2) + " " + rdr.GetString(1);
                cnn.Close();
            }
            else
            {
                Label1.Visible = true;
                Label2.Visible = false;
            }
            cnn.Close();
            cnn.Open();
            if (cmd.ExecuteReader().HasRows)
            {
                Label1.Visible = false;
                Label2.Visible = true;
                Response.Redirect("WebForm1.aspx");

            }
            cnn.Close();



        }
    }
}