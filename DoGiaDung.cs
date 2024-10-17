class DoGiaDung : HangHoa
{
    private DateTime han_bao_hanh;
    public DoGiaDung(string id, string ten_hang, uint so_luong, double don_gia, DateTime han_bao_hanh) : base(id, ten_hang, so_luong, don_gia)
    {
        this.han_bao_hanh = han_bao_hanh;
    }
    public override string ToString()
    {
        return $"{id,-5} | {ten_hang,-20} | {so_luong,-10} | {don_gia,-15} | {han_bao_hanh.ToShortDateString(),-15}";
    }

}