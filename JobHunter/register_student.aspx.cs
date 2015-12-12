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

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        SqlCommand callsave = new SqlCommand("Insert Into students (namesurname, username, password, email) values ('" + txtName.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "')", connection);

        callsave.ExecuteNonQuery();
        lblInfo.Visible = true;
        lblInfo.Text = "Successful!";
        connection.Close();
        connection.Dispose();
    }
}