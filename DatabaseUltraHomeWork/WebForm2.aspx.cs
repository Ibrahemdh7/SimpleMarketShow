using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace DatabaseUltraHomeWork
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        protected void btn_sign_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into Customers (Email,LastName,FirstName,Address,City,State,ZipCode,PhoneNumber,PassWord) values (@email,@last,@first,@address,@city,@state,@zip,@phone,@pass)", con);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@last", txtLastName.Text);
            cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@state", txtState.Text);
            cmd.Parameters.AddWithValue("@zip", txtZip.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);



            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        

        protected void txtEmail_TextChanged1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");

            SqlCommand sc = new SqlCommand("Select* from Customers where Email = @email", con);
            sc.Parameters.AddWithValue("@email", txtEmail.Text);
            con.Open();
            if (sc.ExecuteReader().HasRows)
            {
                d2.Visible = true;
                btn_sign.Enabled = false;

                con.Close();
            }
            else
            {
                d2.Visible = false;

                con.Close();


            }
        }

        protected void txtPhoneNumber_TextChanged1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");

            SqlCommand sc = new SqlCommand("Select* from Customers where PhoneNumber = @phone", con);
            sc.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
            con.Open();
            if (sc.ExecuteReader().HasRows)
            {
                //Session["userinfo"] = txtEmail.Text;
                D3.Visible = true;
                btn_sign.Enabled = false;
                con.Close();
            }
            else
            {
                D3.Visible = false;
                con.Close();


            }

        }
    }
}