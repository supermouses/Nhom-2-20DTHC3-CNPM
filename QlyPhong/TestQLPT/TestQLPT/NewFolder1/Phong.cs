using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Reflection;
using System.Data.Common;

namespace TestQLPT
{
    class Phong
    {
        Database db;

        public Phong()
        {
            db= new Database();
        }
        public DataTable LayDSPhong()
        {
            string str = "SELECT MaPT, TenPT, TinhTrang, MoTa, LoaiPhong FROM Phong a, LoaiPhong b WHERE a.MaLoaiPhong= b.MaLoaiPhong";
            DataTable dt = db.Execute(str);
            return dt;
        }

        public DataTable LayLoaiPhongLenComboBox()
        {
            string str = "SELECT * FROM LoaiPhong";
            DataTable dt = db.Execute(str);
            return dt;
        }

        public void XoaPhong(string mapt)
        {
            string str="Delete from Phong where MaPT= '" +mapt+"'";

            db.ExecuteNonQuery(str);
        }

        public void ThemPhong(string mapt, string tenpt, string tinhtrang, string mota, string loaiphong)
        {
            string str = string.Format("Insert Into Phong values ('{0}',N'{1}',N'{2}',N'{3}',N'{4}')", mapt, tenpt, tinhtrang, mota, loaiphong);
            db.ExecuteNonQuery(str);
        }

        public void SuaPhong(string mapt, string tenpt, string tinhtrang, string mota, string loaiphong)
        {
            string str = string.Format("Update Phong set TenPT= N'"+tenpt+"', TinhTrang=N'"+tinhtrang+"', MoTa=N'"+mota+"', MaLoaiPhong=N'"+loaiphong+"' where MaPT='"+mapt+"'");
            db.ExecuteNonQuery(str);
        }

        public void Timma(string timma)
        {
            string str = "Select MaPT, TenPT, TinhTrang, MoTa, MaLoaiPhong From Phong Where MaPT like '%"+timma+"%'";
            db.ExecuteNonQuery(str);
        }
        public void Timten(string timten)
        {
            string str = "Select MaPT, TenPT, TinhTrang, MoTa, MaLoaiPhong From Phong Where TenPT like '%"+timten+ "%'";
            db.ExecuteNonQuery(str);
        }
    }
}
