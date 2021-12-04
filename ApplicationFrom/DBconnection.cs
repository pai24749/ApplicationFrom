using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace ApplicationFrom
{
    public class DBconnection
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["con"]);
        //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2FVUUO2\SQLEXPRESS;Initial Catalog=HomeMart; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public int add(string spname, List<SqlParameter> para)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(spname, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < para.Count; i++)
            {
                cmd.Parameters.Add(para[i]);
            }
            int counter = cmd.ExecuteNonQuery();
            connection.Close();
            return counter;
        }
        public DataSet GetData(string spname, List<SqlParameter> arr)
        {
            SqlCommand cmd = new SqlCommand(spname, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < arr.Count; i++)
            {
                cmd.Parameters.Add(arr[i]);
            }
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            return DS;
        }
        public Boolean checkMail(string spname, List<SqlParameter> ch)
        {
            SqlCommand cmd = new SqlCommand(spname, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Boolean emailAvailable = false;
            for (int i = 0; i < ch.Count; i++)
            {
                cmd.Parameters.Add(ch[i]);
            }
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count > 0)
                emailAvailable = true;
            return emailAvailable;
        }



    }
}