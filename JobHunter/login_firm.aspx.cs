using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection connection = new SqlConnection(@"data source = (localdb)\ProjectsV13; initial catalog = jobfinder; integrated security = True");

    protected void Page_Load(object sender, EventArgs e)
    {
        connection.Open();


        if (Session["Id"] == null)
        {
            pnlUnlogin.Visible = true;
            pnlLogin.Visible = false;
        }

        else
        {
            pnlUnlogin.Visible = false;
            pnlLogin.Visible = true;
            lblInfo.Text = Session["username"].ToString();
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SqlCommand calllogin = new SqlCommand("Select * From firm where username='" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", connection);

        SqlDataReader drread = calllogin.ExecuteReader();

        if (drread.Read())
        {
            Session["Id"] = drread["Id"].ToString();
            Session["username"] = drread["username"].ToString();
        }

        else
        {
            lblInfo.Text = "This User is not founded!";
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("login.aspx");
    }
}