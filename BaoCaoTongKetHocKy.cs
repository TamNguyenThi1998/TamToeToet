using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoTongKetHocKy
    {
        string MaHocKy;
        string MaLop;
        int SoLuongDat;
        int SiSo;
		float Tile ;

        public BaoCaoTongKetHocKy(string maHK,string maLop,int soLuongDat,int siSo, float tile)
        {
            this.MaHocKy = maHK;
            this.MaLop = maLop;
            this.SoLuongDat = soLuongDat;
            this.SiSo = siSo;
            this.Tile = tile;
        }
    }
}
