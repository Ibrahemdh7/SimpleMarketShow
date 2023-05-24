using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace DatabaseUltraHomeWork
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter ad = new SqlDataAdapter("select* from Products", cnn);

                DataSet ds = new DataSet();
                ad.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();

                SqlDataAdapter ad1 = new SqlDataAdapter("select CategoryID from Categories", cnn);

                DataSet ds1 = new DataSet();
                ad1.Fill(ds1);
      

            }

            if (Session["Name"] != null)
            {
                lblCustomerName.Text = Session["Name"].ToString();
                LinkBtnSignIn.Visible = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
            SqlDataAdapter SDA = new SqlDataAdapter("select* from Products where CategoryID='masks'", cnn);
            DataSet d1 = new DataSet();
            SDA.Fill(d1);
            DataList1.DataSource = d1;
            DataList1.DataBind();

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
            SqlDataAdapter SDA = new SqlDataAdapter("select* from Products where CategoryID='props'", cnn);
            DataSet d1 = new DataSet();
            SDA.Fill(d1);
            DataList1.DataSource = d1;
            DataList1.DataBind();
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
            SqlDataAdapter SDA = new SqlDataAdapter("select* from Products where CategoryID='fx'", cnn);
            DataSet d1 = new DataSet();
            SDA.Fill(d1);
            DataList1.DataSource = d1;
            DataList1.DataBind();
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
            SqlDataAdapter SDA = new SqlDataAdapter("select* from Products where CategoryID='decor'", cnn);
            DataSet d1 = new DataSet();
            SDA.Fill(d1);
            DataList1.DataSource = d1;
            DataList1.DataBind();
        }



        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
            SqlDataAdapter SDA = new SqlDataAdapter("select* from Proudcts where Name like '%"+TextBox1.Text+"%'", cnn);
            DataSet d1 = new DataSet();
            SDA.Fill(d1);
            DataList1.DataSource = d1;
            DataList1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
            DataSet d1 = new DataSet();
            DataList1.DataSource = d1;
            DataList1.DataBind();
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mask.Checked)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where Category ='masks'", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();

            }
            if (chk_mask.Checked && chk_special.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('masks,fx')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_mask.Checked && chk_party.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('masks,decor')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_mask.Checked && chk_props.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('masks,props')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_mask.Checked && chk_cust.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('masks,costumes')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_props.Checked)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where Category ='props'", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_props.Checked && chk_mask.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('props,masks')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_props.Checked && chk_cust.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('props,costumes')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_props.Checked && chk_party.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('props,decor')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_props.Checked && chk_special.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('props,fx')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {


            if (chk_party.Checked)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('decor')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }


            if (chk_party.Checked && chk_special.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('fx,decor')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }



            if (chk_party.Checked && chk_cust.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('decor,costumes')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }


            if (chk_party.Checked && chk_props.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('decor,props')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_party.Checked && chk_mask.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('decor,masks')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_cust.Checked)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('costumes')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }


            if (chk_cust.Checked && chk_props.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('costumes,props')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }


            if (chk_cust.Checked && chk_special.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('costumes,fx')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }


            if (chk_cust.Checked && chk_party.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('costumes,decor')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_cust.Checked && chk_mask.Checked == true)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('costumes,masks')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }
        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_special.Checked)
            {

                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('fx')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }



            if (chk_special.Checked && chk_cust.Checked == true)
            {

                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('decor,fx')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }


            if (chk_special.Checked && chk_props.Checked == true)
            {

                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('fx,props')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }


            if (chk_special.Checked && chk_mask.Checked == true)
            {

                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('fx,masks')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

            if (chk_special.Checked && chk_mask.Checked == true)
            {

                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
                SqlDataAdapter SD = new SqlDataAdapter("select* from Products where CategoryID in ('fx,costumes')", cnn);
                DataSet d1 = new DataSet();
                SD.Fill(d1);
                DataList1.DataSource = d1;
                DataList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IPA devolper\ASP.Net\DatabaseUltraHomeWork\DatabaseUltraHomeWork\App_Data\Database1.mdf;Integrated Security=True");
            SqlDataAdapter ADDP = new SqlDataAdapter("select * from Products where Name like'_%" + TextBox1.Text + "%'", cnn);

            DataSet ds = new DataSet();
            ADDP.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void LinkBtnSignOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            LinkBtnSignIn.Visible = true;
            LinkBtnSignOut.Visible = false;
            Response.Redirect("WebForm1.aspx");
        }

        protected void LinkBtnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }
    }
}