using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using TransparentDeneme.ConnectionCheckFolder;
using System.Data;

namespace TransparentDeneme
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            SqlConnectionClass.CheckConnection(); //Check database connection class of SqlConnectionClass

            SqlCommand sqlCommandToCheckPerMail = new SqlCommand("Select Email from Person where Email='" + exampleInputEmail.Text + "'",SqlConnectionClass.connection);
            SqlDataAdapter sd = new SqlDataAdapter(sqlCommandToCheckPerMail);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0) //There are record person email in database
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Already exist Email! Try Again');", true);

                exampleInputEmail.Text = "";
            }

            else //New record
            {
                //sql komutu :sqlcommand.Tırnakların içine yazılan komut sql komutuna ne yapacağını söylüyor yani sqlcommand'dan oluşturulan nesneye
                SqlCommand sqlCommand = new SqlCommand("Insert into Person (Email,Password) values (@pmail,@ppass)", SqlConnectionClass.connection);
                sqlCommand.Parameters.AddWithValue("@pmail", exampleInputEmail.Text);
                sqlCommand.Parameters.AddWithValue("@ppass", exampleInputPassword1.Text);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully inserted');", true);

                sqlCommand.ExecuteNonQuery();

                exampleInputEmail.Text = "";
            }

        }
    }
}