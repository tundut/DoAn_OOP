using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

abstract class HangHoa
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
}