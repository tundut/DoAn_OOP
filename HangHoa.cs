using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

abstract class HangHoa : ICloneable
{
    public string id;
    public string ten_hang;
    public uint so_luong;
    public double don_gia;

    public HangHoa(string id, string ten_hang, uint so_luong, double don_gia)
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
}