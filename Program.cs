internal class Program
{
    private static void Main(string[] args)
    {
        KhoHang kho = new KhoHang();
        kho.ds_san_pham.Add(new DienTu("DT01", "Quat may", 7, 150000, DateTime.Now.AddMonths(12)));
        kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000, DateTime.Today.AddMonths(12)));
        kho.ds_san_pham.Add(new DoGiaDung("GD01", "Chao chong dinh", 9, 100000, DateTime.Today.AddMonths(12)));
        kho.ds_san_pham.Add(new DoGiaDung("GD02", "Ban an", 3, 500000, DateTime.Today.AddMonths(12)));
        kho.ds_san_pham.Add(new ThucPham("TP01", "Ga nguyen con", 12, 80000, DateTime.Today.AddMonths(1)));
        kho.ds_san_pham.Add(new ThucPham("TP02", "Nuoc ngot", 20, 10000, DateTime.Today.AddMonths(1)));

        kho.ds_nhan_vien.Add(new NhanVien("NV01", "Nguyen Phan Tuan Duc", 19, true, "Quang Ngai"));
        kho.ds_nhan_vien.Add(new NhanVien("NV02", "Huynh Kim Nguyen", 20, false, "TP.HCM"));
        kho.ds_nhan_vien.Add(new NhanVien("NV03", "Nguyen Hoang Bao", 24, true, "Quang Ngai"));
        kho.ds_nhan_vien.Add(new NhanVien("NV04", "Vo Duc Hung", 35, true, "Quang Binh"));



        //Menu
        Console.WriteLine("1. Xem danh sach san pham");
        Console.WriteLine("2. Xem danh sach nhan vien");
        Console.WriteLine("3. Xem danh sach khach hang");
        Console.WriteLine("4. Xem danh sach nha cung cap");
        Console.WriteLine("5. Xuat hang");
        Console.WriteLine("6. Nhap hang");
        Console.WriteLine("7. Lich su");
        Console.WriteLine("0. Thoat");


        int choice = 1;
        while (choice != 0)
        {
            Console.Write("Nhap so: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Danh sach san pham trong kho:");
                    Console.WriteLine($"{"ID",-5} | {"Ten hang",-20} | {"So luong",-10} | {"Don gia",-15} | {"HSD/HBH",-15}");
                    foreach (HangHoa hanghoa in kho.ds_san_pham)
                    {
                        Console.WriteLine(hanghoa.ToString());
                    }
                    break;

                case 2:
                    Console.WriteLine("Danh sach nha vien cua kho:");
                    Console.WriteLine($"{"ID",-5} | {"Ten nhan vien",-20} | {"Tuoi",-5} | {"Gioi tinh",-10} | {"Dia chi",-20}");
                    foreach (NhanVien nhanvien in kho.ds_nhan_vien)
                    {
                        Console.WriteLine(nhanvien.ToString());
                    }
                    break;

                case 3:
                    Console.WriteLine("Danh sach khach hang: ");
                    Console.WriteLine($"{"Ten"} | {"Dia chi"} | {"So dien thoai"}");
                    foreach (KhachHang kh in kho.ds_khach_hang)
                    {
                        Console.WriteLine($"{kh.ten_kh,-20} | {kh.dia_chi_kh,-20} | {kh.sdt_kh,-15}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Danh sach nha cung cap: ");
                    Console.WriteLine($"{"Ten"} | {"Dia chi"} | {"So dien thoai"}");
                    foreach (NhaCungCap ncc in kho.ds_ncc)
                    {
                        Console.WriteLine($"{ncc.ten_ncc,-20} | {ncc.dia_chi_ncc,-20} | {ncc.sdt_ncc,-15}");
                    }
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 0:
                    break;


            }
        }
    }
}