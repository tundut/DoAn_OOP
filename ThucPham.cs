class ThucPham : HangHoa
{
    private DateTime han_su_dung;
    public ThucPham(string id, string ten_hang, uint so_luong, double don_gia, DateTime han_su_dung) : base(id, ten_hang, so_luong, don_gia)
    {
        this.han_su_dung = han_su_dung;
    }
    public override string ToString()
    {
        return $"{id,-5} | {ten_hang,-20} | {so_luong,-10} | {don_gia,-15} | {han_su_dung.ToShortDateString(),-15}";
    }
}