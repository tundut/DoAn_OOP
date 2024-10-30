using System.Text;
using System.Runtime.Serialization;

[Serializable]
public class HoaDonXuat : HoaDon
{
    CuaHang cua_hang;
    public HoaDonXuat()
    {

    }
    public HoaDonXuat(string ma_don_hang, QuanLyNhapXuat ds_san_pham, NhanVien nv_lap, CuaHang cua_hang) : base(ma_don_hang, ds_san_pham, nv_lap)
    {
        ngay_tao_don = DateTime.Now;
        this.cua_hang = cua_hang;
    }

    public override StringBuilder ToString()
    {
        double tong_tien = 0;
        StringBuilder hoadon = new StringBuilder();
        hoadon.AppendLine($"Hoa Don Xuat:");
        hoadon.AppendLine($" - Ma don hang: {ma_don_hang}");
        hoadon.AppendLine($" - Ngay tao don: {ngay_tao_don.ToShortDateString()}");
        hoadon.AppendLine($" - Nhan vien lap: {nv_lap.ten_nv}");
        hoadon.AppendLine($" - Cua hang nhan: {cua_hang.ten_ch}");
        hoadon.AppendLine($" - Danh sach san pham:");
        hoadon.AppendLine($"{"ID",-5} | {"Ten hang",-20} | {"So luong",-10} | {"Don gia",-15}");
        foreach (HangHoa hangHoa in ds_san_pham.ds_san_pham)
        {
            hoadon.AppendLine(hangHoa.ToString());
            tong_tien += hangHoa.don_gia * hangHoa.so_luong;
        }
        hoadon.AppendLine($" - Tong tien: {tong_tien}");

        return hoadon;
    }

    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue("cua_hang", cua_hang);
    }

    public HoaDonXuat(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        cua_hang = (CuaHang)info.GetValue("cua_hang", typeof(CuaHang));
    }

}