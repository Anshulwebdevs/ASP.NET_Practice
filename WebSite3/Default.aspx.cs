using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "This is a Label";
        ListBox1.Items.Add("Sunday");
        ListBox1.Items.Add("Monday");
        ListBox1.Items.Add("Tuesday");
        ListBox1.Items.Add("Wednesday");
        ListBox1.Items.Add("Thurday");
        ListBox1.Items.Add("Friday");
        ListBox1.Items.Add("Saturday");
        Image1.ImageUrl = "Chrysanthemum.jpg";
        Image1.AlternateText="Cannot Open image";
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Button clicked";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label2.Text = "You selected "+DropDownList1.SelectedItem.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label3.Text = "You Selected : " + ListBox1.SelectedItem.ToString();
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            Label4.Text = "Checkbox clicked";

        }
        else
        {
            Label4.Text = "";
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked == true)
        {
            Label5.Text = "You selected : ASP.NET";
        }
        else if (RadioButton2.Checked== true)
        {
           Label5.Text = "You selected : VB.NET";
        }
        else if (RadioButton3.Checked == true)
        {
            Label5.Text = "You selected : C#";
        }
        else {
            Label5.Text = "";
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Label6.Text="YOU CLICKED LINK";
    }
}