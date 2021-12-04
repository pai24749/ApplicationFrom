using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace ApplicationFrom
{
    public partial class Registration : System.Web.UI.Page
    {
        DBconnection db = new DBconnection();
        
        DataSet ds = new DataSet();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            empBind();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2FVUUO2\SQLEXPRESS;Initial Catalog=HomeMart;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("UserRegi_Test", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Fname", Fname.Text);
            para[1] = new SqlParameter("@Lname", Lname.Text);
            para[2] = new SqlParameter("@email", email.Text);
            para[3] = new SqlParameter("@address", Address.Text);
            para[4] = new SqlParameter("@city", city.Text);
            para[5] = new SqlParameter("@eduName",eduDetails.SelectedItem.Text);
            para[6] = new SqlParameter("@percantage", Convert.ToDecimal(percantage.Text));
            para[7] = new SqlParameter("@subjectName", subjectName.Text);
            para[8] = new SqlParameter("@mode","INSERTUSER");
            for (int i = 0; i < para.Length; i++)
            {
                cmd.Parameters.Add(para[i]);
            }
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            if (count > 0) {
                Response.Write("<script>alert('Saved Successfully ')</script>");
                empBind();
            }
            else
            {
                Response.Write("<script>alert('no data saved Successfully ')</script>");
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Convert.ToString(args.Value) == "")
            {

            }
        }

        public void empBind()
        {
            ds = EmpList();
            repit1.DataSource = ds.Tables[0];
            repit1.DataBind();
        }

        protected void repit1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int delVal = Convert.ToInt32(e.CommandArgument);
            //u.Flag = 'D';

            int a = userDelete(delVal);
            if (a > 0)
            {
                Response.Write("<script>alert('Succesfully')</script>");
                empBind();
            }

        }

        public DataSet EmpList()
        {
            List<SqlParameter> arr1 = new List<SqlParameter>();
            arr1.Add(new SqlParameter("@mode", "SELECTEMP"));
            ds = db.GetData("UserRegi_Test", arr1);
            return ds;
        }
        public int userDelete(int Val)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@userId", Val));
            param.Add(new SqlParameter("@mode", "DELETE"));
            int output = db.add("UserRegi_Test", param);
            return output;
        }
    }
}