using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTBaoCaoTongKetMon
    {
        string MaBCTKM ;
	    string	MaLop ;
        int SiSo;
		int SoLuongDatMon ;
		float TiLeDatMon ;

        public CTBaoCaoTongKetMon(string maBaoCao,string maLop,int siSo, int soLuongDat,float tiLe)
        {
            this.MaBCTKM = maBaoCao;
            this.MaLop = maLop;
            this.SiSo = siSo;
            this.SoLuongDatMon = soLuongDat;
            this.TiLeDatMon = tiLe;
        }

    }
}
