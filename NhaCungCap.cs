class NhaCungCap
{
    public string id_ncc;
    public string ten_ncc;
    public string dia_chi_ncc;
    public NhaCungCap(string id_ncc, string ten_ncc, string dia_chi_ncc)
    {
        this.id_ncc = id_ncc;
        this.ten_ncc = ten_ncc;
        this.dia_chi_ncc = dia_chi_ncc;
    }
    public override string ToString()
    {
        return $"{id_ncc,-10} | {ten_ncc,-20} | {dia_chi_ncc,-20}";
    }
}