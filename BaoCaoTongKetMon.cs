using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoTongKetMon
    {
        string MaBCTKM;
        string MaMonHoc ;
		string MaHocKy ;

        public BaoCaoTongKetMon(string maBaoCao,string maMH,string MaHK)
        {
            this.MaBCTKM = maBaoCao;
            this.MaMonHoc = maMH;
            this.MaHocKy = MaHK;
        }
    }
}
