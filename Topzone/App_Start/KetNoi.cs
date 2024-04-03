using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace TOPZONE.App_Start
{
	public class KetNoi
	{
        private string connectString = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=Topzone;Integrated Security=True";
        public SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            return conn;
        }

        public DataTable InThongTin(string sqlQuery)
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, getConnect());
            adapter.Fill(data);
            return data;
        }

        public int ExcuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection ketnoi = new SqlConnection(connectString))
            {
                ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, ketnoi);
                data = thucthi.ExecuteNonQuery();
                ketnoi.Close();
            }
            return data;
        }
        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ketnoi = new SqlConnection(connectString))
            {
                ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, ketnoi);
                SqlDataAdapter laydulieu = new SqlDataAdapter(thucthi);
                laydulieu.Fill(dt);
                ketnoi.Close();
            }
            return dt;
        }
        public SqlDataReader ExcuteReader(string sqlQuery)
        {
            SqlCommand cmd = new SqlCommand(sqlQuery, getConnect());
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}