class CuaHang
{
    public string id_ch;
    public string ten_ch;
    public string dia_chi_ch;
    public CuaHang(string id_ch, string ten_ch, string dia_chi_ch)
    {
        this.id_ch = id_ch;
        this.ten_ch = ten_ch;
        this.dia_chi_ch = dia_chi_ch;
    }

    public override string ToString()
    {
        return $"{id_ch,-5} | {ten_ch,-20} | {dia_chi_ch,-20}";
    }
}