class DienTu : HangHoa
{
    public DienTu(string id, string ten_hang, uint so_luong, double don_gia) : base(id, ten_hang, so_luong, don_gia)
    {

    }
    public override string ToString()
    {
        return $"{id,-5} | {ten_hang,-20} | {so_luong,-10} | {don_gia,-15}";
    }

}