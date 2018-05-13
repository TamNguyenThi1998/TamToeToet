using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BaoCaoTongKetHocKyBLL : DatabaseBLL
    {
        public BaoCaoTongKetHocKyBLL() : base()
        { }

        public List<BaoCaoTongKetHocKy> GetListBaoCaoTongKetHocKy()
        {
            BaoCaoTongKetHocKyAccess baoCaoTongKetHocKyAccess = new BaoCaoTongKetHocKyAccess();
            return baoCaoTongKetHocKyAccess.GetAllBaoCaoTongKetHocKy();
        }

        public bool XoaBaoCaoTongKetHocKy(string MaHocKy, string MaLop)
        {
            BaoCaoTongKetHocKyAccess BCTKHK = new BaoCaoTongKetHocKyAccess();
            return BCTKHK.XoaBaoCaoTongKetHocKy(MaHocKy, MaLop);
        }

        public bool ThemBaoCaoTongKetHocKy(string MaHocKy, string MaLop, int SoLuongDat, int SiSo, float Tile)
        {
            BaoCaoTongKetHocKyAccess BaoCaoTKHK = new BaoCaoTongKetHocKyAccess();
            return BaoCaoTKHK.ThemBaoCaoTongKetHocKy(MaHocKy, MaLop, SoLuongDat, SiSo, Tile);
        }

        public bool SuaBaoCaoTongKetHocKy(string MaHocKy, string MaLop, int SoLuongDat, int SiSo, float Tile)
        {
            BaoCaoTongKetHocKyAccess BCTKHocKy = new BaoCaoTongKetHocKyAccess();
            return BCTKHocKy.SuaBaoCaoTongKetHocKy(MaHocKy, MaLop, SoLuongDat, SiSo, Tile);
        }
    }
}
