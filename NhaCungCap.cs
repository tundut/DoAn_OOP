class NhaCungCap
{
    public string ten_ncc;
    public string dia_chi_ncc;
    public string sdt_ncc;
    public NhaCungCap(string ten_ncc, string dia_chi_ncc, string sdt_ncc)
    {
        this.ten_ncc = ten_ncc;
        this.dia_chi_ncc = dia_chi_ncc;
        this.sdt_ncc = sdt_ncc;
    }
    public override string ToString()
    {
        return $"{ten_ncc,-20}, {dia_chi_ncc,-20}, {sdt_ncc,-15}";
    }
}