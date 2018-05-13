using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CTBaoCaoTongKetMonBLL : DatabaseBLL
    {
        public CTBaoCaoTongKetMonBLL() : base()
        { }

        public List<CTBaoCaoTongKetMon> GetListCTBaoCaoTongKetMon()
        {
            CTBaoCaoTongKetMonAccess CTBCTongKetMonAccess = new CTBaoCaoTongKetMonAccess();
            return CTBCTongKetMonAccess.GetAllCTBaoCaoTongKetMon();
        }

        public bool XoaCTBaoCaoTongKetMon(string MaBCTKM, string MaLop)
        {
            CTBaoCaoTongKetMonAccess CTBC = new CTBaoCaoTongKetMonAccess();
            return CTBC.XoaCTBaoCaoTongKetMon(MaBCTKM, MaLop);
        }

        public bool ThemCTBaoCaoTongKetMon(string MaBCTKM, string MaLop, int SiSo, int SoLuongDatMon, float TiLeDatMon)
        {
            CTBaoCaoTongKetMonAccess CTBaoCao = new CTBaoCaoTongKetMonAccess();
            return CTBaoCao.ThemCTBaoCaoTongKetMon(MaBCTKM, MaLop, SiSo, SoLuongDatMon, TiLeDatMon);
        }

        public bool SuaCTBaoCaoTongKetMon(string MaBCTKM, string MaLop, int SiSo, int SoLuongDatMon, float TiLeDatMon)
        {
            CTBaoCaoTongKetMonAccess CTBCTKMac = new CTBaoCaoTongKetMonAccess();
            return CTBCTKMac.SuaCTBaoCaoTongKetMon(MaBCTKM, MaLop, SiSo, SoLuongDatMon, TiLeDatMon);
        }
    }
}
