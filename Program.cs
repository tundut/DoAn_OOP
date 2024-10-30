using System.Runtime.ExceptionServices;
using System.Transactions;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        KhoHang kho = new KhoHang();
        // kho.ds_san_pham.Add(new DienTu("DT01", "Quat may", 7, 150000));
        // kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
        // kho.ds_san_pham.Add(new DoGiaDung("GD01", "Chao chong dinh", 9, 100000));
        // kho.ds_san_pham.Add(new DoGiaDung("GD02", "Ban an", 3, 500000));
        // kho.ds_san_pham.Add(new ThucPham("TP01", "Ga nguyen con", 12, 80000));
        // kho.ds_san_pham.Add(new ThucPham("TP02", "Nuoc ngot", 20, 10000));

        XmlSerializer serializer1 = new XmlSerializer(typeof(List<HangHoa>));
        string filePath1 = "Resources/hang_hoa.dat";

        // using (StreamWriter writer = new StreamWriter(filePath1))
        // {
        //     serializer1.Serialize(writer, kho.ds_san_pham);
        // }

        using (StreamReader reader = new StreamReader(filePath1))
        {
            kho.ds_san_pham = (List<HangHoa>)serializer1.Deserialize(reader);
        }



        // kho.ds_nhan_vien.Add(new NhanVien("NV01", "Nguyen Phan Tuan Duc", 19, true, "Quang Ngai"));
        // kho.ds_nhan_vien.Add(new NhanVien("NV02", "Huynh Kim Nguyen", 20, false, "TP.HCM"));
        // kho.ds_nhan_vien.Add(new NhanVien("NV03", "Nguyen Hoang Bao", 24, true, "Quang Ngai"));
        // kho.ds_nhan_vien.Add(new NhanVien("NV04", "Vo Duc Hung", 35, true, "Quang Binh"));

        XmlSerializer serializer2 = new XmlSerializer(typeof(List<NhanVien>));
        string filePath2 = "Resources/nhan_vien.dat";

        // using (StreamWriter writer = new StreamWriter(filePath2))
        // {
        //     serializer2.Serialize(writer, kho.ds_nhan_vien);
        // }

        using (StreamReader reader = new StreamReader(filePath2))
        {
            kho.ds_nhan_vien = (List<NhanVien>)serializer2.Deserialize(reader);
        }



        // kho.ds_cua_hang.Add(new CuaHang("CH01", "Cua hang 1", "Binh Thanh"));
        // kho.ds_cua_hang.Add(new CuaHang("CH02", "Cua hang 2", "Quan 3"));
        // kho.ds_cua_hang.Add(new CuaHang("CH03", "Cua hang 3", "Quan 10"));

        XmlSerializer serializer3 = new XmlSerializer(typeof(List<CuaHang>));
        string filePath3 = "Resources/cua_hang.dat";

        // using (StreamWriter writer = new StreamWriter(filePath3))
        // {
        //     serializer3.Serialize(writer, kho.ds_cua_hang);
        // }

        using (StreamReader reader = new StreamReader(filePath3))
        {
            kho.ds_cua_hang = (List<CuaHang>)serializer3.Deserialize(reader);
        }



        // kho.ds_ncc.Add(new NhaCungCap("NCC01", "ABC Corporation", "Tan Binh"));
        // kho.ds_ncc.Add(new NhaCungCap("NCC02", "XYZ Corporation", "Binh Chanh"));
        // kho.ds_ncc.Add(new NhaCungCap("NCC03", "DEF Corporation", "Binh Thanh"));

        XmlSerializer serializer4 = new XmlSerializer(typeof(List<NhaCungCap>));
        string filePath4 = "Resources/nha_cung_cap.dat";

        // using (StreamWriter writer = new StreamWriter(filePath4))
        // {
        //     serializer4.Serialize(writer, kho.ds_ncc);
        // }

        using (StreamReader reader = new StreamReader(filePath4))
        {
            kho.ds_ncc = (List<NhaCungCap>)serializer4.Deserialize(reader);
        }


        XmlSerializer serializer5 = new XmlSerializer(typeof(List<HoaDonNhap>));
        string filePath5 = "Resources/hoa_don_nhap.dat";
        using (StreamReader reader = new StreamReader(filePath5))
        {
            kho.ds_hoa_don_nhap = (List<HoaDonNhap>)serializer5.Deserialize(reader);
        }

        XmlSerializer serializer6 = new XmlSerializer(typeof(List<HoaDonXuat>));
        string filePath6 = "Resources/hoa_don_xuat.dat";
        using (StreamReader reader = new StreamReader(filePath6))
        {
            kho.ds_hoa_don_xuat = (List<HoaDonXuat>)serializer6.Deserialize(reader);
        }




        NhanVien nv_hien_tai = kho.ds_nhan_vien.Find(nv => nv.id_nv == "NV01");

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
                    Console.WriteLine($"{"ID",-5} | {"Ten nha cung cap",-20} | {"Dia chi",-20}");
                    foreach (NhaCungCap ncc in kho.ds_ncc)
                    {
                        Console.WriteLine(ncc.ToString());
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

                                HangHoa sp_them = (HangHoa)kho.ds_san_pham.Find(hanghoa => hanghoa.id == id_them).Clone();
                                HangHoa sp_ton_tai = ds_nhap.ds_san_pham.Find(hanghoa => hanghoa.id == id_them);

                                if (sp_them != null)
                                {
                                    if (sp_ton_tai == null)
                                    {
                                        sp_them.so_luong = so_luong_them;
                                        ds_nhap.them_sp(sp_them);
                                    }
                                    else
                                    {
                                        Console.WriteLine("San pham da ton tai");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("San pham khong ton tai");
                                }
                                break;

                            case 2:
                                Console.Write("Nhap ID san pham muon xoa: ");
                                string id_xoa = Console.ReadLine();

                                HangHoa sp_xoa = ds_nhap.ds_san_pham.Find(hanghoa => hanghoa.id == id_xoa);
                                if (sp_xoa != null)
                                {
                                    ds_nhap.xoa_sp(sp_xoa);
                                }
                                else
                                {
                                    Console.WriteLine("San pham khong ton tai");
                                }
                                break;

                            case 3:
                                Console.Write("Nhap ID san pham muon sua: ");
                                string id_sua = Console.ReadLine();

                                HangHoa sp_sua = ds_nhap.ds_san_pham.Find(hanghoa => hanghoa.id == id_sua);
                                if (sp_sua != null)
                                {
                                    Console.Write("Nhap so luong san pham moi: ");
                                    uint so_luong_moi = Convert.ToUInt32(Console.ReadLine());
                                    ds_nhap.capnhat_sp(sp_sua, so_luong_moi);
                                }
                                else
                                {
                                    Console.WriteLine("San pham khong ton tai");
                                }
                                break;

                            case 4:
                                Console.Write("Nhap ID nha cung cap: ");
                                string id_ncc_cc = Console.ReadLine();

                                NhaCungCap ncc = kho.ds_ncc.Find(x => x.id_ncc == id_ncc_cc);
                                kho.capnhatkho(ds_nhap.ds_san_pham, true);
                                Console.WriteLine("Nhap hang thanh cong");

                                HoaDonNhap hoa_don_nhap = new HoaDonNhap($"HD{kho.ds_hoa_don_nhap.Count + 1}", ds_nhap, nv_hien_tai, ncc);
                                kho.them_hoa_don_nhap(hoa_don_nhap);

                                ds_nhap = null;
                                ncc = null;
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

                                HangHoa sp_them = (HangHoa)kho.ds_san_pham.Find(hanghoa => hanghoa.id == id_them).Clone();
                                HangHoa sp_ton_tai = ds_xuat.ds_san_pham.Find(hanghoa => hanghoa.id == id_them);

                                if (sp_them != null)
                                {
                                    if (kho.kha_dung(sp_them) == true)
                                    {
                                        if (sp_ton_tai == null)
                                        {
                                            sp_them.so_luong = so_luong_them;
                                            ds_xuat.them_sp(sp_them);
                                        }
                                        else
                                        {
                                            Console.WriteLine("San pham da ton tai");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("So luong san pham trong kho khong du");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("San pham khong ton tai");
                                }
                                break;

                            case 2:
                                Console.Write("Nhap ID san pham muon xoa: ");
                                string id_xoa = Console.ReadLine();

                                HangHoa sp_xoa = ds_xuat.ds_san_pham.Find(hanghoa => hanghoa.id == id_xoa);
                                if (sp_xoa != null)
                                {
                                    ds_xuat.xoa_sp(sp_xoa);
                                }
                                else
                                {
                                    Console.WriteLine("San pham khong ton tai");
                                }
                                break;

                            case 3:
                                Console.Write("Nhap ID san pham muon sua: ");
                                string id_sua = Console.ReadLine();

                                HangHoa sp_sua = ds_xuat.ds_san_pham.Find(hanghoa => hanghoa.id == id_sua);
                                if (sp_sua != null)
                                {
                                    Console.Write("Nhap so luong san pham moi: ");
                                    uint so_luong_moi = Convert.ToUInt32(Console.ReadLine());
                                    if (kho.kha_dung(sp_sua) == true)
                                    {
                                        ds_xuat.capnhat_sp(sp_sua, so_luong_moi);
                                    }
                                    else
                                    {
                                        Console.WriteLine("So luong san pham trong kho khong du");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("San pham khong ton tai");
                                }
                                break;

                            case 4:
                                Console.Write("Nhap ID cua hang nhan: ");
                                string id_ch_nhan = Console.ReadLine();

                                CuaHang ch_nhan = kho.ds_cua_hang.Find(x => x.id_ch == id_ch_nhan);
                                kho.capnhatkho(ds_xuat.ds_san_pham, false);
                                Console.WriteLine("Xuat hang thanh cong");

                                HoaDonXuat hoa_don_xuat = new HoaDonXuat($"HD{kho.ds_hoa_don_xuat.Count + 1}", ds_xuat, nv_hien_tai, ch_nhan);
                                kho.them_hoa_don_xuat(hoa_don_xuat);
                                ds_xuat = null;
                                ch_nhan = null;
                                break;
                            case 0:
                                break;
                        }
                    }
                    break;

                case 7:
                    Console.WriteLine("Danh sach hoa don nhap:");
                    foreach (HoaDon hoa_don in kho.ds_hoa_don_nhap)
                    {
                        Console.WriteLine(hoa_don.ToString());
                    }

                    Console.WriteLine("Danh sach hoa don xuat:");
                    foreach (HoaDon hoa_don in kho.ds_hoa_don_xuat)
                    {
                        Console.WriteLine(hoa_don.ToString());
                    }
                    break;

                default:

                case 0:
                    using (StreamWriter writer = new StreamWriter(filePath1))
                    {
                        serializer1.Serialize(writer, kho.ds_san_pham);
                    }

                    using (StreamWriter writer = new StreamWriter(filePath2))
                    {
                        serializer2.Serialize(writer, kho.ds_nhan_vien);
                    }

                    using (StreamWriter writer = new StreamWriter(filePath3))
                    {
                        serializer3.Serialize(writer, kho.ds_cua_hang);
                    }

                    using (StreamWriter writer = new StreamWriter(filePath4))
                    {
                        serializer4.Serialize(writer, kho.ds_ncc);
                    }

                    using (StreamWriter writer = new StreamWriter(filePath5))
                    {
                        serializer5.Serialize(writer, kho.ds_hoa_don_nhap);
                    }

                    using (StreamWriter writer = new StreamWriter(filePath6))
                    {
                        serializer6.Serialize(writer, kho.ds_hoa_don_xuat);
                    }
                    break;
            }
        }
    }
}