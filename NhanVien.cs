using System.Runtime.Serialization;

[Serializable]
public class NhanVien : ISerializable
{
    public string id_nv;
    public string ten_nv;
    public uint tuoi;
    public bool gioi_tinh;
    public string dia_chi_nv;

    public NhanVien()
    {

    }
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

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("id_nv", id_nv);
        info.AddValue("ten_nv", ten_nv);
        info.AddValue("tuoi", tuoi);
        info.AddValue("gioi_tinh", gioi_tinh);
        info.AddValue("dia_chi_nv", dia_chi_nv);
    }

    public NhanVien(SerializationInfo info, StreamingContext context)
    {
        id_nv = info.GetString("id_nv");
        ten_nv = info.GetString("ten_nv");
        tuoi = info.GetUInt32("tuoi");
        gioi_tinh = info.GetBoolean("gioi_tinh");
        dia_chi_nv = info.GetString("dia_chi_nv");
    }
}