using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_teamProject
{
    public class DBHelper
    {
        private  SqlConnection conn = new SqlConnection();
        //DB에 있는 데이터를 가져 오는 부분들
        public SqlDataAdapter da;
        public DataSet ds;
        public DataTable dt;
       
        //db 열고 -> crud 수행 -> db 닫아줌
        private void ConnectDB()
        {
            string dataSource = "local";
            string db = "memeberDB"; //오타
            string security = "SSPI";
            conn.ConnectionString = string.Format
                ("Data Source=({0}); initial Catalog={1}; " +
                "integrated Security = {2};" +
                "Timeout=3", dataSource, db, security);
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public usertable_ty DBMypage(string id)
        {
            try
            {
                ConnectDB(); //db 연결

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn; //어디에 커맨드 보낼지 지정
                //cmd.CommandText = "update usertable set user_name='modify' where user_id=" + id;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";

                sqlcommand = "select * from usertable where user_id=@p1";
                 cmd.Parameters.AddWithValue("@p1", id);
                cmd.CommandText = sqlcommand;

                SqlDataReader sdr = cmd.ExecuteReader();

                usertable_ty us = new usertable_ty();

                while(sdr.Read()) {
                    us.user_name = sdr["user_name"].ToString();
                    us.user_id = sdr["user_id"].ToString();
                    us.user_phonenum = sdr["user_phonenum"].ToString();
                    us.user_email = sdr["user_email"].ToString(); 

                }
                return us;

            }
            catch (Exception e)
            {
                Console.WriteLine("select" + e.StackTrace);
                return null;
            }
            finally
            {
                conn.Close(); //db 연결 해제
            }
        }


    }
}
