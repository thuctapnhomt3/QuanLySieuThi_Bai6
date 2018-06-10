using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    class MyControl
    {
        //thuc hien len ! tra ve chu sucess khi thanh cong
        public String ExecuteMyQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
                {
                    connection.Open();
                    SqlCommand commandAddNV = new SqlCommand(query, connection);
                    commandAddNV.ExecuteNonQuery();
                    connection.Close();
                    return "Success !!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //thuc hien lenh : tra ve la ket qua cau lenh dang string
        public String ExecuteMyQueryScalar(string query)
        {
            string result;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
                {
                    connection.Open();
                    SqlCommand commandAddNV = new SqlCommand(query, connection);
                    result = Convert.ToString(commandAddNV.ExecuteScalar());
                    connection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return "ERROR"+ex.Message;
            }
        }

        //thuc hien cau lenh : tra ve so : thanh cong 1 / that bai tra ve 0
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }


            return data;
        }













       
    }
}
