class KhoHang
{
    string ten_kho;
    public List<HangHoa> ds_san_pham = new List<HangHoa>();
    public List<NhanVien> ds_nhan_vien = new List<NhanVien>();
    public List<CuaHang> ds_cua_hang = new List<CuaHang>();
    public List<NhaCungCap> ds_ncc = new List<NhaCungCap>();
    public List<HoaDon> ds_hoa_don = new List<HoaDon>();

    bool kha_dung(HangHoa hh)
    {
        return true;
    }

    public void capnhatkho(List<HangHoa> ds_hh, bool nhap_xuat)
    {
        if (nhap_xuat)
        {
            foreach (HangHoa hanghoa in ds_hh)
            {
                foreach (HangHoa hangHoa_kho in ds_san_pham)
                {
                    if (hanghoa.id == hangHoa_kho.id)
                    {
                        hangHoa_kho.so_luong += hanghoa.so_luong;
                        break;
                    }
                }
            }
        }
        else
        {
            foreach (HangHoa hanghoa in ds_hh)
            {
                foreach (HangHoa hangHoa_kho in ds_san_pham)
                {
                    if (hanghoa.id == hangHoa_kho.id)
                    {
                        hangHoa_kho.so_luong -= hanghoa.so_luong;
                        break;
                    }
                }
            }
        }

    }
}