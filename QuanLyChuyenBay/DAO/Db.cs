using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay.DAO
{
    public class Db
    {
        string duong_dan = @"Data Source=kennie\sqlexpress;Initial Catalog=QuanLyChuyenBay;Integrated Security=True";
        protected DataTable LayDuLieu(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);            
            SqlDataAdapter bo_chuyen_doi = new SqlDataAdapter(sql, ket_noi);
            DataTable bang = new DataTable();
            bo_chuyen_doi.Fill(bang);
            return bang;
        }
        protected int ThucThi(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            ket_noi.Open();
            var rs = lenh.ExecuteNonQuery();
            ket_noi.Close();
            return rs;
        }
        protected string LayTen(string sql)
        {
            string ten = "";
            SqlConnection ket_noi = new SqlConnection(duong_dan);
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            lenh.CommandType = CommandType.Text;
            ket_noi.Open();
            if (ket_noi.State == ConnectionState.Open)
            {
                object result = lenh.ExecuteScalar();
                if (result != null)
                {
                    ten = result.ToString();
                }
            }
            return ten;
        }
        protected int LaySo(string sql)
        {
           int so = 0;
            SqlConnection ket_noi = new SqlConnection(duong_dan);
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            lenh.CommandType = CommandType.Text;
            ket_noi.Open();
            if (ket_noi.State == ConnectionState.Open)
            {
                object result = lenh.ExecuteScalar();
                if (result != null)
                {
                    int.TryParse(result.ToString(), out so);
                }
            }
            return so;
        }
        protected DataTable LayDanhSachXacThuc(string sql, Dictionary<string, object> parameters)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);
            SqlDataAdapter bo_chuyen_doi = new SqlDataAdapter(sql, ket_noi);

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    bo_chuyen_doi.SelectCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
            }

            DataTable bang = new DataTable();
            bo_chuyen_doi.Fill(bang);
            return bang;
        }

    }

}
