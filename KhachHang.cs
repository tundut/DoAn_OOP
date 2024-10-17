class KhachHang
{
    public string ten_kh;
    public string dia_chi_kh;
    public string sdt_kh;
    public override string ToString()
    {
        return $"{ten_kh,-20}, {dia_chi_kh,-20}, {sdt_kh,-15}";
    }
}