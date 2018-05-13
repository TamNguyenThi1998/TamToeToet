using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class BaoCaoTongKetHocKyAccess : DatabaseAccess
    {
        public BaoCaoTongKetHocKyAccess() : base()
        { }

        public List<BaoCaoTongKetHocKy> GetAllBaoCaoTongKetHocKy()
        {
            OpenConnection();

            List<BaoCaoTongKetHocKy> listBaoCaoTongKetHocKy = new List<BaoCaoTongKetHocKy>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from BaoCaoTongKetHocKy";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string MaHocKy = reader.GetString(0);
                string MaLop = reader.GetString(1);
                int SoLuongDat = reader.GetInt32(2);
                int SiSo = reader.GetInt32(3);
                float Tile = reader.GetFloat(4);

                BaoCaoTongKetHocKy baoCaoTongKetHocKy = new BaoCaoTongKetHocKy(MaHocKy, MaLop, SoLuongDat, SiSo, Tile);
                listBaoCaoTongKetHocKy.Add(baoCaoTongKetHocKy);
            }

            reader.Close();
            CloseConnection();
            return listBaoCaoTongKetHocKy;
        }

        public bool XoaBaoCaoTongKetHocKy(string MaHocKy, string MaLop)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from BaoCaoTongKetHocKy where MaHocKy=@MaHocKy and MaLop=@MaLop";
            com.Parameters.Add("@MaHocKy", SqlDbType.VarChar).Value = MaHocKy;
            com.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = MaLop;
            com.Connection = conn;

            try
            {
                int check = com.ExecuteNonQuery();
                if (check > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }

        public bool ThemBaoCaoTongKetHocKy(string MaHocKy, string MaLop, int SoLuongDat, int SiSo, float Tile)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into MonHoc values(@MaHocKy,@MaLop, @SoLuongDat, @SiSo, @Tile)";
                com.Connection = conn;

                com.Parameters.Add("@MaHocKy", SqlDbType.VarChar).Value = MaHocKy;
                com.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = MaLop;
                com.Parameters.Add("@SoLuongDat", SqlDbType.Int).Value = SoLuongDat;
                com.Parameters.Add("@SiSo", SqlDbType.Int).Value = SiSo;
                com.Parameters.Add("@Tile", SqlDbType.Float).Value = Tile;

                int result = com.ExecuteNonQuery();

                CloseConnection();
                if (result > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaBaoCaoTongKetHocKy(string MaHocKy, string MaLop, int SoLuongDat, int SiSo, float Tile)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "update  BaoCaoTongKetHocKy set SoLuongDat = @SoLuongDat and SiSo = @SiSo and Tile = @Tile where  MaHocKy=@MaHocKy and MaLop=@MaLop";
                com.Connection = conn;

                com.Parameters.Add("@MaHocKy", SqlDbType.VarChar).Value = MaHocKy;
                com.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = MaLop;
                com.Parameters.Add("@SoLuongDat", SqlDbType.Int).Value = SoLuongDat;
                com.Parameters.Add("@SiSo", SqlDbType.Int).Value = SiSo;
                com.Parameters.Add("@Tile", SqlDbType.Float).Value = Tile;


                int result = com.ExecuteNonQuery();

                CloseConnection();
                if (result > 0)
                    return true;
                return false;

            }
            catch
            {
                return false;
            }
        }
    }
}
