using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Configuration;

namespace ApplicationFrom
{
    public partial class editData : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        DBconnection db = new DBconnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userBind();
            }
        }
        protected void userBind()
        {
            if (Request.QueryString["eid"] == null)
            {
                Response.Write("<script>alert('ID is null')</script>");
                Response.Redirect("Registration.aspx");
            }
            else
            {
                int val = Convert.ToInt32(Request.QueryString["eid"]);
                ds = selectAll(val);
                userId.Value = ds.Tables[0].Rows[0]["user_id"].ToString();
                name.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
                Lname.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
                Email.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                add.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                city.Text = ds.Tables[0].Rows[0]["City"].ToString();
                eduDetails.SelectedItem.Text = ds.Tables[0].Rows[0]["eduName"].ToString();
                percantage.Text = ds.Tables[0].Rows[0]["percantage"].ToString();
                subjectName.Text = ds.Tables[0].Rows[0]["subjectName"].ToString();
            }
        }
        public DataSet selectAll(int val)
        {
            DataSet ds = new DataSet();
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@userId", val));
            param.Add(new SqlParameter("@mode", "SELECTALL"));
            ds = db.GetData("UserRegi_Test", param);
            return ds;
        }

        protected void submit_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2FVUUO2\SQLEXPRESS;Initial Catalog=HomeMart;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("UserRegi_Test", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@Fname", name.Text);
            para[1] = new SqlParameter("@Lname", Lname.Text);
            para[2] = new SqlParameter("@email", Email.Text);
            para[3] = new SqlParameter("@address", add.Text);
            para[4] = new SqlParameter("@city", city.Text);
            para[5] = new SqlParameter("@userId", userId.Value);
            para[6] = new SqlParameter("@eduName", eduDetails.SelectedItem.Text.ToString());
            para[7] = new SqlParameter("@percantage", Convert.ToDecimal(percantage.Text));
            para[8] = new SqlParameter("@subjectName", subjectName.Text);
            para[9] = new SqlParameter("@mode", "UPDATE");
            for (int i = 0; i < para.Length; i++)
            {
                cmd.Parameters.Add(para[i]);
            }
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Registration.aspx");
        }
    }
}