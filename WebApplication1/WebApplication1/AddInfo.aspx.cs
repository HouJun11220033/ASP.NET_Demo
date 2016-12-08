using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;



namespace WebApplication1
{
    public partial class EditInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // string name, age, num, sex;
            string strCon=ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            string strSql = "insert into stuinfo values(@name,@num,@age,@sex)";
            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql,conn);
            cmd.Parameters.Add("@name", SqlDbType.NChar, 10).Value = Sname.Text;
            cmd.Parameters.Add("@num", SqlDbType.NChar, 10).Value = Snum.Text;
            cmd.Parameters.Add("@age", SqlDbType.NChar, 10).Value = Sage.Text;
            cmd.Parameters.Add("@sex", SqlDbType.NChar, 10).Value = Ssex.SelectedItem.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListInfo.aspx");
        }
    }
}