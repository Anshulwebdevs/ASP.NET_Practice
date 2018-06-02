using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into Table1 values(@eno,@ename,@eadd,@esal)";
        cmd.Connection = con;
        cmd.Parameters.Add("@eno",SqlDbType.Int).Value=Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@ename", SqlDbType.VarChar,50).Value = TextBox2.Text;
        cmd.Parameters.Add("@eadd", SqlDbType.VarChar,50).Value =TextBox3.Text;
        cmd.Parameters.Add("@esal", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        clr_rec();
                                                                                                                                                                                        
    }
    private void clr_rec() 
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from Table1";
        cmd.Connection = con;
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        ListBox1.DataTextField = "Ename";
        ListBox1.DataValueField = "Eno";
        ListBox1.DataSource = dr;
        ListBox1.DataBind();
        dr.Close();
        cmd.Dispose();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from table1 where eno=@eno";
        cmd.Connection = con;
        cmd.Parameters.Add("@eno", SqlDbType.Int).Value = Convert.ToInt32(ListBox1.SelectedValue);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            TextBox1.Text = dr["eno"].ToString();
            TextBox2.Text = dr["ename"].ToString();
            TextBox3.Text = dr["eadd"].ToString();
            TextBox4.Text = dr["esal"].ToString();
            dr.Close();
            cmd.Dispose();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from table1 where eno=@eno";
        cmd.Connection = con;
        cmd.Parameters.Add("@eno", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        clr_rec();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "update table1 set ename=@ename,eadd=@eadd,esal=@esal where eno=@eno";
        cmd.Parameters.Add("@eno", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@ename", SqlDbType.VarChar, 50).Value = TextBox2.Text;
        cmd.Parameters.Add("@eadd", SqlDbType.VarChar, 50).Value = TextBox3.Text;
        cmd.Parameters.Add("@esal", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        clr_rec();
    }
}