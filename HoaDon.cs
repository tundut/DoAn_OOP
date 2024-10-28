abstract class HoaDon
{
    string ma_don_hang;
    DateTime ngay_tao_don;
    QuanLyNhapXuat ds_san_pham;
    NhanVien nv_lap;

    public HoaDon(string ma_don_hang, DateTime ngay_tao_don, QuanLyNhapXuat ds_san_pham, NhanVien nv_lap)
    {
        this.ma_don_hang = ma_don_hang;
        this.ngay_tao_don = ngay_tao_don;
        this.ds_san_pham = ds_san_pham;
        this.nv_lap = nv_lap;
    }

    public abstract string ToString();
}