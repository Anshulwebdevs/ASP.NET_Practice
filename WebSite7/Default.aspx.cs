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
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            listbind();
        }
    }
    protected void listbind()
    {
        SqlDataAdapter adp=new SqlDataAdapter("select * from table1",ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds =new DataSet();
        adp.Fill(ds);
        DataList1.DataSource=ds;
        DataList1.DataBind();
    }

    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = e.Item.ItemIndex;
        listbind();

    }
    protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = -1;
        listbind();
    }

    protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        Int32 eno, esal;
        string ename, eadd;
        eno = Convert.ToInt32(((TextBox)(e.Item.FindControl("TextBox1"))).Text);
        esal = Convert.ToInt32(((TextBox)(e.Item.FindControl("TextBox4"))).Text);
        eadd = ((TextBox)(e.Item.FindControl("TextBox3"))).Text;
        ename = ((TextBox)(e.Item.FindControl("TextBox2"))).Text;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update table1 set ename=@ename,esal=@esal,eadd=@eadd where eno=@eno";
        cmd.Connection = con;
        cmd.Parameters.Add("@eno", SqlDbType.Int).Value = eno;
        cmd.Parameters.Add("@ename", SqlDbType.VarChar,50).Value = ename;
        cmd.Parameters.Add("@eadd", SqlDbType.VarChar, 50).Value = eadd;
        cmd.Parameters.Add("@esal", SqlDbType.Int).Value = esal;
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        DataList1.EditItemIndex = -1;
        listbind();
    }
}