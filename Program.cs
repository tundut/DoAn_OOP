using System.Runtime.ExceptionServices;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        KhoHang kho = new KhoHang();
        kho.ds_san_pham.Add(new DienTu("DT01", "Quat may", 7, 150000));
        kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
        kho.ds_san_pham.Add(new DoGiaDung("GD01", "Chao chong dinh", 9, 100000));
        kho.ds_san_pham.Add(new DoGiaDung("GD02", "Ban an", 3, 500000));
        kho.ds_san_pham.Add(new ThucPham("TP01", "Ga nguyen con", 12, 80000));
        kho.ds_san_pham.Add(new ThucPham("TP02", "Nuoc ngot", 20, 10000));

        kho.ds_nhan_vien.Add(new NhanVien("NV01", "Nguyen Phan Tuan Duc", 19, true, "Quang Ngai"));
        kho.ds_nhan_vien.Add(new NhanVien("NV02", "Huynh Kim Nguyen", 20, false, "TP.HCM"));
        kho.ds_nhan_vien.Add(new NhanVien("NV03", "Nguyen Hoang Bao", 24, true, "Quang Ngai"));
        kho.ds_nhan_vien.Add(new NhanVien("NV04", "Vo Duc Hung", 35, true, "Quang Binh"));

        kho.ds_cua_hang.Add(new CuaHang("CH01", "Cua hang 1", "Binh Thanh"));
        kho.ds_cua_hang.Add(new CuaHang("CH02", "Cua hang 2", "Quan 3"));
        kho.ds_cua_hang.Add(new CuaHang("CH03", "Cua hang 3", "Quan 10"));

        kho.ds_ncc.Add(new NhaCungCap("NCC01", "ABC Corporation", "0987654321"));
        kho.ds_ncc.Add(new NhaCungCap("NCC02", "XYZ Corporation", "0123456789"));
        kho.ds_ncc.Add(new NhaCungCap("NCC03", "DEF Corporation", "1234567890"));



        Console.WriteLine("1. Xem danh sach san pham");
        Console.WriteLine("2. Xem danh sach nhan vien");
        Console.WriteLine("3. Xem danh sach khach hang");
        Console.WriteLine("4. Xem danh sach nha cung cap");
        Console.WriteLine("5. Nhap hang");
        Console.WriteLine("6. Xuat hang");
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
                    Console.WriteLine($"{"ID",-5} | {"Ten hang",-20} | {"So luong",-10} | {"Don gia",-15}");
                    Console.WriteLine("-------------------------------------------");
                    foreach (HangHoa hanghoa in kho.ds_san_pham)
                    {
                        Console.WriteLine(hanghoa.ToString());
                    }
                    break;

                case 2:
                    Console.WriteLine("Danh sach nha vien cua kho:");
                    Console.WriteLine($"{"ID",-5} | {"Ten nhan vien",-20} | {"Tuoi",-5} | {"Gioi tinh",-10} | {"Dia chi",-20}");
                    Console.WriteLine("-------------------------------------------");
                    foreach (NhanVien nhanvien in kho.ds_nhan_vien)
                    {
                        Console.WriteLine(nhanvien.ToString());
                    }
                    break;

                case 3:
                    Console.WriteLine("Danh sach cua hang: ");
                    Console.WriteLine($"{"ID",-5} | {"Ten",-20} | {"Dia chi",-20}");
                    Console.WriteLine("-------------------------------------------");
                    foreach (CuaHang ch in kho.ds_cua_hang)
                    {
                        Console.WriteLine(ch.ToString());
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
                    QuanLyNhapXuat ds_nhap = new QuanLyNhapXuat();

                    int choice_nhap = 1;
                    while (choice_nhap != 0 && choice_nhap != 4)
                    {
                        Console.WriteLine("Danh sach san pham nhap: ");
                        Console.WriteLine($"{"ID",-5} | {"Ten hang",-20} | {"So luong",-10} | {"Don gia",-15}");
                        if (ds_nhap.ds_san_pham != null)
                        {
                            foreach (HangHoa hanghoa in ds_nhap.ds_san_pham)
                            {
                                Console.WriteLine(hanghoa.ToString());
                            }
                        }
                        Console.WriteLine("1: Them san pham");
                        Console.WriteLine("2: Xoa san pham");
                        Console.WriteLine("3: Sua san pham");
                        Console.WriteLine("4: Xac nhan");
                        Console.WriteLine("0: Huy");
                        Console.Write("Nhap so: ");
                        choice_nhap = Convert.ToInt32(Console.ReadLine());
                        switch (choice_nhap)
                        {
                            case 1:
                                Console.Write("Nhap ID san pham muon them: ");
                                string id_them = Console.ReadLine();
                                Console.Write("Nhap so luong san pham: ");
                                uint so_luong_them = Convert.ToUInt32(Console.ReadLine());
                                HangHoa sp_them;
                                foreach (HangHoa hanghoa in kho.ds_san_pham)
                                {
                                    if (hanghoa.id == id_them)
                                    {
                                        sp_them = (HangHoa)hanghoa.Clone();
                                        sp_them.so_luong = so_luong_them;
                                        ds_nhap.them_sp(sp_them);
                                        break;
                                    }
                                    if (kho.ds_san_pham.IndexOf(hanghoa) == kho.ds_san_pham.Count - 1)
                                    {
                                        Console.WriteLine("San pham khong ton tai");
                                    }
                                }
                                break;
                            case 2:
                                Console.Write("Nhap ID san pham muon xoa: ");
                                string id_xoa = Console.ReadLine();
                                foreach (HangHoa hanghoa in ds_nhap.ds_san_pham)
                                {
                                    if (hanghoa.id == id_xoa)
                                    {
                                        ds_nhap.xoa_sp(hanghoa);
                                        break;
                                    }
                                    if (ds_nhap.ds_san_pham.IndexOf(hanghoa) == ds_nhap.ds_san_pham.Count - 1)
                                    {
                                        Console.WriteLine("San pham khong ton tai");
                                    }
                                }
                                break;
                            case 3:
                                Console.Write("Nhap ID san pham muon sua: ");
                                string id_sua = Console.ReadLine();
                                foreach (HangHoa hanghoa in ds_nhap.ds_san_pham)
                                {
                                    if (hanghoa.id == id_sua)
                                    {
                                        Console.Write("Nhap so luong san pham moi: ");
                                        uint so_luong_moi = Convert.ToUInt32(Console.ReadLine());
                                        ds_nhap.capnhat_sp(hanghoa, so_luong_moi);
                                        break;
                                    }
                                    if (ds_nhap.ds_san_pham.IndexOf(hanghoa) == ds_nhap.ds_san_pham.Count - 1)
                                    {
                                        Console.WriteLine("San pham khong ton tai");
                                    }
                                }
                                break;
                            case 4:
                                kho.capnhatkho(ds_nhap.ds_san_pham, true);
                                Console.WriteLine("Nhap hang thanh cong");
                                ds_nhap = null;
                                break;
                            case 0:
                                break;
                        }
                    }
                    break;

                case 6:
                    QuanLyNhapXuat ds_xuat = new QuanLyNhapXuat();

                    int choice_xuat = 1;
                    while (choice_xuat != 0 && choice_xuat != 4)
                    {
                        Console.WriteLine("Danh sach san pham xuat: ");
                        Console.WriteLine($"{"ID",-5} | {"Ten hang",-20} | {"So luong",-10} | {"Don gia",-15}");
                        if (ds_xuat.ds_san_pham != null)
                        {
                            foreach (HangHoa hanghoa in ds_xuat.ds_san_pham)
                            {
                                Console.WriteLine(hanghoa.ToString());
                            }
                        }
                        Console.WriteLine("1: Them san pham");
                        Console.WriteLine("2: Xoa san pham");
                        Console.WriteLine("3: Sua san pham");
                        Console.WriteLine("4: Xac nhan");
                        Console.WriteLine("0: Huy");
                        Console.Write("Nhap so: ");
                        choice_xuat = Convert.ToInt32(Console.ReadLine());
                        switch (choice_xuat)
                        {
                            case 1:
                                Console.Write("Nhap ID san pham muon them: ");
                                string id_them = Console.ReadLine();
                                Console.Write("Nhap so luong san pham: ");
                                uint so_luong_them = Convert.ToUInt32(Console.ReadLine());
                                HangHoa sp_them;
                                foreach (HangHoa hanghoa in kho.ds_san_pham)
                                {
                                    if (hanghoa.id == id_them)
                                    {
                                        sp_them = (HangHoa)hanghoa.Clone();
                                        sp_them.so_luong = so_luong_them;
                                        ds_xuat.them_sp(sp_them);
                                        break;
                                    }
                                    if (kho.ds_san_pham.IndexOf(hanghoa) == kho.ds_san_pham.Count - 1)
                                    {
                                        Console.WriteLine("San pham khong ton tai");
                                    }
                                }
                                break;
                            case 2:
                                Console.Write("Nhap ID san pham muon xoa: ");
                                string id_xoa = Console.ReadLine();
                                foreach (HangHoa hanghoa in ds_xuat.ds_san_pham)
                                {
                                    if (hanghoa.id == id_xoa)
                                    {
                                        ds_xuat.xoa_sp(hanghoa);
                                        break;
                                    }
                                    if (ds_xuat.ds_san_pham.IndexOf(hanghoa) == ds_xuat.ds_san_pham.Count - 1)
                                    {
                                        Console.WriteLine("San pham khong ton tai");
                                    }
                                }
                                break;
                            case 3:
                                Console.Write("Nhap ID san pham muon sua: ");
                                string id_sua = Console.ReadLine();
                                foreach (HangHoa hanghoa in ds_xuat.ds_san_pham)
                                {
                                    if (hanghoa.id == id_sua)
                                    {
                                        Console.Write("Nhap so luong san pham moi: ");
                                        uint so_luong_moi = Convert.ToUInt32(Console.ReadLine());
                                        ds_xuat.capnhat_sp(hanghoa, so_luong_moi);
                                        break;
                                    }
                                    if (ds_xuat.ds_san_pham.IndexOf(hanghoa) == ds_xuat.ds_san_pham.Count - 1)
                                    {
                                        Console.WriteLine("San pham khong ton tai");
                                    }
                                }
                                break;
                            case 4:
                                kho.capnhatkho(ds_xuat.ds_san_pham, false);
                                Console.WriteLine("Xuat hang thanh cong");
                                ds_xuat = null;
                                break;
                            case 0:
                                break;
                        }
                    }
                    break;

                case 7:

                    break;

                case 0:
                    break;


            }
        }
    }
}