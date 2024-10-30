using System.Runtime.Serialization;
using System.Text;

[Serializable]
public class HoaDonNhap : HoaDon
{
    NhaCungCap nha_cung_cap;
    public HoaDonNhap()
    {

    }
    public HoaDonNhap(string ma_don_hang, QuanLyNhapXuat ds_san_pham, NhanVien nv_lap, NhaCungCap nha_cung_cap) : base(ma_don_hang, ds_san_pham, nv_lap)
    {
        this.nha_cung_cap = nha_cung_cap;
        ngay_tao_don = DateTime.Now;
    }


    public override StringBuilder ToString()
    {
        double tong_tien = 0;
        StringBuilder hoadon = new StringBuilder();
        hoadon.AppendLine($"Hoa Don Nhap:");
        hoadon.AppendLine($" - Ma don hang: {ma_don_hang}");
        hoadon.AppendLine($" - Ngay tao don: {ngay_tao_don.ToShortDateString()}");
        hoadon.AppendLine($" - Nhan vien lap: {nv_lap.ten_nv}");
        hoadon.AppendLine($" - Nha cung cap: {nha_cung_cap.id_ncc}");
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
        info.AddValue("nha_cung_cap", nha_cung_cap);
    }

    public HoaDonNhap(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        nha_cung_cap = (NhaCungCap)info.GetValue("nha_cung_cap", typeof(NhaCungCap));
    }

}