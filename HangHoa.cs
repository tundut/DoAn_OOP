using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Xml.Serialization;
[XmlInclude(typeof(DienTu))]
[XmlInclude(typeof(DoGiaDung))]
[XmlInclude(typeof(ThucPham))]
[Serializable]
public abstract class HangHoa : ICloneable, ISerializable
{
    public string id { get; set; }
    public string ten_hang { get; set; }
    public uint so_luong { get; set; }
    public long don_gia { get; set; }

    protected HangHoa()
    {

    }

    public HangHoa(string id, string ten_hang, uint so_luong, long don_gia)
    {
        this.id = id;
        this.ten_hang = ten_hang;
        this.so_luong = so_luong;
        this.don_gia = don_gia;
    }

    public override abstract string ToString();
    public object Clone()
    {
        HangHoa clone = (HangHoa)this.MemberwiseClone();
        clone.id = this.id;
        clone.ten_hang = this.ten_hang;
        clone.don_gia = this.don_gia;
        return clone;
    }

    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("id", id);
        info.AddValue("ten_hang", ten_hang);
        info.AddValue("so_luong", so_luong);
        info.AddValue("don_gia", don_gia);
    }

    public HangHoa(SerializationInfo info, StreamingContext context)
    {
        id = info.GetString("id");
        ten_hang = info.GetString("ten_hang");
        so_luong = info.GetUInt32("so_luong");
        don_gia = info.GetInt64("don_gia");
    }
}