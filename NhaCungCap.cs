class NhaCungCap
{
    public string ten_ncc;
    public string dia_chi_ncc;
    public string sdt_ncc;
    public override string ToString()
    {
        return $"{ten_ncc,-20}, {dia_chi_ncc,-20}, {sdt_ncc,-15}";
    }
}