using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class connectsql
    {
        // tạo câu lệnh kết nối sql
        static private string strcon = "Data Source=DESKTOP-TSOEQU7\\SQLEXPRESS;Initial Catalog=qlxm;Integrated Security=True";
        protected  bool executenonquery(string query)
        {
            SqlConnection con = new SqlConnection(strcon);// kết nối sql
            try
            {
                con.Open(); // mở kết nối
                SqlCommand cmd = new SqlCommand(query, con); // thực thi câu query trên kết nối
                if (cmd.ExecuteNonQuery() > 0) // kiểm tra số query thực thi
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close(); // đóng kết nối
            }
            return false;
        }
        protected object getvalue(string query)
        {
            DataTable data1 = new DataTable();
            SqlConnection con = new SqlConnection(strcon);// kết nối sql
            try
            {
                con.Open(); // mở kết nối
                SqlCommand cmd = new SqlCommand(query, con); // thực thi câu query trên kết nối
               // if (cmd.ExecuteNonQuery() == 1) // kiểm tra số query thực thi
                    return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close(); // đóng kết nối
            }
            return 0;
        }
        protected DataTable gettable(string query)
        {
            
            DataTable data = new DataTable(); //  tạo 1 datatable
            using (SqlConnection con = new SqlConnection(strcon)) // kết nối sql
            {
                con.Open(); // mở kết nối
                SqlCommand t = new SqlCommand(query, con);// thực thi câu query trên kết nối
                SqlDataAdapter a = new SqlDataAdapter(t);
                a.Fill(data);// đổ dữ liệu vào data
                con.Close();// đóng kết nối
            }
            return data;
        }

    }
}

