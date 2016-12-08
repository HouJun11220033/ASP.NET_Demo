using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected string strCon = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            BindVoid();
        }
        public void BindVoid() {
           //..........................................................
           SqlConnection con = new SqlConnection(strCon);
           SqlCommand cmd = new SqlCommand("select * from stuinfo", con);
           SqlDataAdapter sda = new SqlDataAdapter(cmd);
           DataSet dt = new DataSet();
           con.Open();
           sda.Fill(dt);
           
           //...........................................................
           GridView_Stu.DataSource= dt;
           GridView_Stu.DataBind();
           con.Close();
      //     GridView_Stu.HeaderRow.RowIndex(0) = "asd";
           //已经拿到数据了，接下来需要将数据显示到前端
        //   GridView_Stu.Columns[0].HeaderText = "xing";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddInfo.aspx");
        }
        //-----------------------------全选-------------------------------
        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
           
            for (int i = 0; i <= GridView_Stu.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)GridView_Stu.Rows[i].FindControl("CheckBox1");
                
                if (CheckBox2.Checked == true)
                {
                    cbox.Checked = true;
                }
                else
                {
                    cbox.Checked = false;
                }
            }
        }



        //-----------------------------单行删除-------------------------------
        protected void GridView_Stu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("delete from stuinfo where Snum=@num", con);
            int index_row=e.RowIndex;
            GridViewRow gvr=GridView_Stu.Rows[index_row];
            String strSnum=gvr.Cells[2].Text;

            cmd.Parameters.Add("@num", SqlDbType.NChar, 10).Value = strSnum;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
          
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataSet dt = new DataSet();

        }

        //-------------------------批量删除----------------------------------

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd;
            for (int i = 0; i < GridView_Stu.Rows.Count; i++)
            {
                CheckBox cbox = (CheckBox)GridView_Stu.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked == true)
                {
                    String strSql = "delete from stuinfo where Snum=@num";
                    cmd = new SqlCommand(strSql, con);
                    cmd.Parameters.Add("num", SqlDbType.NChar, 10).Value = GridView_Stu.Rows[i].Cells[2].Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            

        }

        //删除时候弹出确认对话框
        //protected void GridView_Stu_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
        //        {
        //           ((LinkButton)e.Row.Cells[6].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：/"" + e.Row.Cells[1].Text + "/"吗?')");
 
        //        }
        //    }

        //}
        
        
        


    }
}