using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Data;
using System.Data.SqlClient;

namespace DanhnhanHost
{
    public class Danhnhan : IDanhnhan
    {
        public String GetAuthors()
        {
            return " HỒ TẤN VŨ 093614   LÊ QUỐC BẢO ";
        }
        public String Detai()
        {
            return " Tạo dịch vụ web DANH NHÂN ";
        }

        public SqlConnection KetNoi()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DANHNHAN.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        }
        public DataSet ShowAll()
        {
            SqlConnection conn = KetNoi();
            string sql = "SELECT * FROM DANHNHAN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet ShowImage()
        {
            SqlConnection conn = KetNoi();
            string sql = "SELECT * FROM HINHANH";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet GetTable(String query)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        [OperationBehavior(TransactionScopeRequired = true,
                              TransactionAutoComplete = true)]
        public void ExcuteNoneQuery(String query)
        {
            SqlConnection conn = KetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public String GetTenDanhMuc(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TENDANHMUC FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetTen(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TEN FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetDanhHieu(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DANHHIEU FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetNienHieu(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT NIENHIEU FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetNgaySinh(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT NGAYSINH FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetNgayMat(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT NGAYMAT FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetNoiSinh(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT NOISINH FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetTaiNang(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TAINANG FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetSuNghiep(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUNGHIEP FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetThanhTuu(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT THANHTUU FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetHoatDong(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT HOATDONG FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetGiaiThuong(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT GIAITHUONG FROM DANHNHAN WHERE TENDANHMUC LIKE '%" + condition + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public String GetPathHinhanh(String condition)
        {
            SqlConnection conn = KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT HINH FROM HINHANH WHERE TEN = N'" + condition + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return System.IO.Path.GetFullPath(ds.Tables[0].Rows[0][0].ToString());
        }
    }
}
