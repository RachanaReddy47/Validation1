using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Validation1
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            

                Adp = new SqlDataAdapter("sp_Validation1", Con);
                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adp.SelectCommand.Parameters.AddWithValue("@Eid", txtEmpid.Text);
                Adp.SelectCommand.Parameters.AddWithValue("@Pwd", txtPswd.Text);
                DS = new DataSet();
                Adp.Fill(DS, "E");
                DataRow R = DS.Tables["E"].Rows[0];
                if (R[3].ToString() == "Admin")
                {
                    Response.Cookies["name"].Value = R[1].ToString();
                    Response.Redirect("Admin.aspx");
                }

                else if (R[3].ToString() == "Associate")
                {
                    Response.Cookies["name"].Value = R[1].ToString();
                    Response.Redirect("Associate.aspx");
                }
                else

            

            //catch(IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Invalid Credentials");
            //}
        }
    }
}