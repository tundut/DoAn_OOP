class NhanVien
{
    private string id_nv;
    private string ten_nv;
    private uint tuoi;
    private bool gioi_tinh;
    private string dia_chi_nv;
    public NhanVien(string id_nv, string ten_nv, uint tuoi, bool gioi_tinh, string dia_chi_nv)
    {
        this.id_nv = id_nv;
        this.ten_nv = ten_nv;
        this.tuoi = tuoi;
        this.gioi_tinh = gioi_tinh;
        this.dia_chi_nv = dia_chi_nv;
    }

    public override string ToString()
    {
        string gioi_tinh;
        if (this.gioi_tinh) gioi_tinh = "Nam";
        else gioi_tinh = "Nu";
        return $"{id_nv,-5} | {ten_nv,-20} | {tuoi,-5} | {gioi_tinh,-10} | {dia_chi_nv,-20}";
    }
}