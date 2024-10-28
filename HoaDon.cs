using System.Text;

abstract class HoaDon
{
    public string ma_don_hang;
    public DateTime ngay_tao_don;
    public QuanLyNhapXuat ds_san_pham;
    public NhanVien nv_lap;

    public HoaDon(string ma_don_hang, QuanLyNhapXuat ds_san_pham, NhanVien nv_lap)
    {
        this.ma_don_hang = ma_don_hang;
        this.ngay_tao_don = DateTime.Now;
        this.ds_san_pham = ds_san_pham;
        this.nv_lap = nv_lap;
    }

    public abstract StringBuilder ToString();
}