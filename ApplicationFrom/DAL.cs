using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HomeDAL
{
    //public class DAL
    //{
    //    DBconnection obj = new DBconnection();
    //    DataSet ds = new DataSet();
    //    User u = new User();
    //    AddToCart A = new AddToCart();
    //    int rowCount;

    //    public int user_insert(User u)
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@roleId", u.roleId));
    //        param.Add(new SqlParameter("@Fname", u.Fname));
    //        param.Add(new SqlParameter("@Lname", u.Lname));
    //        param.Add(new SqlParameter("@pincode", u.pincode));
    //        param.Add(new SqlParameter("@email", u.email));
    //        param.Add(new SqlParameter("@number1", u.number));
    //        param.Add(new SqlParameter("@address", u.addres));
    //        param.Add(new SqlParameter("@city", u.city));
    //        param.Add(new SqlParameter("@gender", u.Gender));
    //        param.Add(new SqlParameter("@flag", u.Flag));
    //        param.Add(new SqlParameter("@Cdate", u.Cdate));
    //        param.Add(new SqlParameter("@password", u.password));
    //        param.Add(new SqlParameter("@mode", "INSERTUSER"));
    //        rowCount = obj.add("UserRegi", param);
    //        return rowCount;
    //    }
    //    public int user_update(User u)
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@pin", u.pincode));
    //        param.Add(new SqlParameter("@email_n", u.email));
    //        param.Add(new SqlParameter("@number_n1", u.number));
    //        param.Add(new SqlParameter("@Fname_n", u.Fname));
    //        param.Add(new SqlParameter("@Lname_n", u.Lname));
    //        param.Add(new SqlParameter("@add", u.addres));
    //        param.Add(new SqlParameter("@city", u.city));
    //        // param.Add(new SqlParameter("@Flag", u.Flag));
    //        //  param.Add(new SqlParameter("@Udate", u.Udate));
    //        param.Add(new SqlParameter("@password", u.password));
    //        param.Add(new SqlParameter("@mode", "UPDATE"));
    //        rowCount = obj.add("UserRegi", param);
    //        return rowCount;
    //    }
    //    public int emp_update(User u)
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@GST", u.GST));
    //        param.Add(new SqlParameter("@email", u.email));
    //        param.Add(new SqlParameter("@number2", u.number2));
    //        param.Add(new SqlParameter("@shopName", u.ShopName));
    //        param.Add(new SqlParameter("@shopAdd", u.ShopAdd));
    //        // param.Add(new SqlParameter("@Flag", u.Flag));
    //        //  param.Add(new SqlParameter("@Udate", u.Udate));
    //        param.Add(new SqlParameter("@mode", "UPDATE"));
    //        rowCount = obj.add("UserRegi", param);
    //        return rowCount;
    //    }
    //    public int product_add(productAdd p)
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@ProductName", p.name));
    //        param.Add(new SqlParameter("@mrp", p.mrp));
    //        param.Add(new SqlParameter("@discount", p.discount));
    //        param.Add(new SqlParameter("@weight", p.weight));
    //        param.Add(new SqlParameter("@scale", p.scale));
    //        param.Add(new SqlParameter("@DiscountPrice", p.Discountprice));
    //        param.Add(new SqlParameter("@Flag", p.falg));
    //        param.Add(new SqlParameter("@Cdate", p.Cdate));
    //        param.Add(new SqlParameter("@Udate", p.Udate));
    //        param.Add(new SqlParameter("@Font_Images", p.Font_Image));
    //        param.Add(new SqlParameter("@back_Images", p.back_Image));
    //        param.Add(new SqlParameter("@Nutration_Images", p.Nutration_Image));
    //        param.Add(new SqlParameter("@Ingradient_Images", p.Ingradient_Image));
    //        param.Add(new SqlParameter("@Contact_Images", p.Contact_Image));
    //        param.Add(new SqlParameter("@mode", "INSERT"));
    //        rowCount = obj.add("productP", param);
    //        return rowCount;
    //    }
    //    public int AddToCartProduct(productAdd p)
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@Id", p.Id));
    //        param.Add(new SqlParameter("@EmailId", p.name));
    //        param.Add(new SqlParameter("@itemCount", p.mrp));
    //        param.Add(new SqlParameter("@mode", p.Font_Image));
    //        rowCount = obj.add("Proc_AddToCart", param);
    //        return rowCount;
    //    }

    //    /*------------------------------------------check the details / email ------------------------------------------------------------*/
    //    public Boolean checkMail(User u)
    //    {
    //        Boolean emailAvailable = false;
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@email", u.email));
    //        param.Add(new SqlParameter("@mode", "SELECT"));
    //        emailAvailable = obj.checkMail("UserRegi", param);
    //        return emailAvailable;
    //    }
    //    public Boolean checkLog(User u)
    //    {
    //        Boolean emailAvailable = false;
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@email", u.email));
    //        param.Add(new SqlParameter("@password", u.password));
    //        param.Add(new SqlParameter("@mode", "CHECKLOG"));
    //        emailAvailable = obj.checkMail("UserRegi", param);
    //        return emailAvailable;
    //    }
    //    public Boolean checkUser(User u)
    //    {
    //        Boolean emailAvailable = false;
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@email", u.email));
    //        param.Add(new SqlParameter("@roleId", 1));
    //        param.Add(new SqlParameter("@password", u.password));
    //        param.Add(new SqlParameter("@mode", "CHECKUSER"));
    //        emailAvailable = obj.checkMail("UserRegi", param);
    //        return emailAvailable;
    //    }

    //    /*------------------------------------------delete data / flag ------------------------------------------------------------*/
    //    public int Product_delete(productAdd p)
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@Id", p.Id));
    //        // param.Add(new SqlParameter("@flag", p.falg));
    //        param.Add(new SqlParameter("@mode", "DELETE"));
    //        rowCount = obj.add("productP", param);

    //        return rowCount;
    //    }
    //    public int userDelete(User u)
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@userId", u.userId));
    //        param.Add(new SqlParameter("@flag", u.Flag));
    //        param.Add(new SqlParameter("@mode", "DELETE"));
    //        int output = obj.add("UserRegi", param);
    //        return output;
    //    }
    //    public int ProductDelete(productAdd p)
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@Id", p.Id));
    //        param.Add(new SqlParameter("@mode", "DELETE"));
    //        int output = obj.add("productP", param);
    //        return output;
    //    }
    //    /*------------------------------------------DataSet / Table set ------------------------------------------------------------*/
    //    public DataSet Product_list()
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@mode", "SELECT"));
    //        ds = obj.GetData("productP", param);
    //        return ds;
    //    }
    //    public DataSet selectAll(User u)
    //    {
    //        DataSet ds = new DataSet();
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@Id", u.roleId));
    //        param.Add(new SqlParameter("@mode", "SELECTALL"));
    //        ds = obj.GetData("UserRegi", param);
    //        return ds;
    //    }
    //    public DataSet EmpList()
    //    {
    //        List<SqlParameter> arr1 = new List<SqlParameter>();
    //        arr1.Add(new SqlParameter("@roleId", 2));
    //        arr1.Add(new SqlParameter("@mode", "SELECTEMP"));
    //        ds = obj.GetData("UserRegi", arr1);
    //        return ds;
    //    }
    //    public DataSet UserList()
    //    {
    //        List<SqlParameter> arr1 = new List<SqlParameter>();
    //        arr1.Add(new SqlParameter("@roleId", 3));
    //        arr1.Add(new SqlParameter("@mode", "SELECTEMP"));
    //        ds = obj.GetData("UserRegi", arr1);
    //        return ds;
    //    }
    //    public DataSet User_list()
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@email", u.email));
    //        param.Add(new SqlParameter("@mode", "SELECT"));
    //        ds = obj.GetData("productP", param);
    //        return ds;
    //    }
    //    public DataSet Ad()
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@mode", "SELECT"));
    //        ds = obj.GetData("AD", param);
    //        return ds;
    //    }
    //    /*----------------------------------------------------------------------------AddToCart------------------------------------------------------------*/

    //    public DataSet AddToCart(AddToCart A)
    //    {
    //        List<SqlParameter> param = new List<SqlParameter>();
    //        param.Add(new SqlParameter("@EmailId", A.EmailId));
    //        param.Add(new SqlParameter("@mode", "SelectAddToCart"));
    //        ds = obj.GetData("productP", param);
    //        return ds;
    //    }

    //}


}