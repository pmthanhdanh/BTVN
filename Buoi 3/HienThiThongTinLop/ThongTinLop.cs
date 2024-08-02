using System;
namespace BTVN_Buoi3 //Tạo namespace BTVN_Buoi3
{
	public class ThongTinLop //Tạo lớp ThongTinLop
	{
		struct ThongTin //Tạo biến ThongTin với kiểu dữ liệu Structure
		{
			public string HoTen; //Tạo biến HoTen với kiểu dữ liệu String, với phạm vi truy cập Public
			public int NamSinh; //Tạo biến NamSinh với kiểu dữ liệu Int, với phạm vi truy cập Public
            public string QueQuan; //Tạo biến QueQuan với kiểu dữ liệu String, với phạm vi truy cập Public
        }
		static void MainLop() //Tạo phương thức Main để chạy chương trình
		{
			ThongTin P1 = new ThongTin(); //Tạo biến P1 với kiểu dữ liệu ThongTin và gán cho nó 1 đối tượng mới được khởi tạo từ kiểu ThongTin
			P1.HoTen = "Do Huy Viet Hung"; //Gán giá trị cho thuộc tính HoTen của P1
			P1.NamSinh = 2002; //Gán giá trị cho thuộc tính NamSinh của P1
            P1.QueQuan = "Bac Giang"; //Gán giá trị cho thuộc tính QueQuan của P1

            //Làm tương tự với các biến P còn lại

            ThongTin P2 = new ThongTin();
            P2.HoTen = "Tran Thien Nhan";
            P2.NamSinh = 2004;
            P2.QueQuan = "Tien Giang";

            ThongTin P3 = new ThongTin();
            P3.HoTen = "Le Quang Vu";
            P3.NamSinh = 1992;
            P3.QueQuan = "Ha Noi";

            ThongTin P4 = new ThongTin();
            P4.HoTen = "Tran Dinh Thang";
            P4.NamSinh = 2001;
            P4.QueQuan = "Nam Dinh";

            ThongTin P5 = new ThongTin();
            P5.HoTen = "Pham Thai Cong";
            P5.NamSinh = 1995;
            P5.QueQuan = "Ha Noi";

            ThongTin P6 = new ThongTin();
            P6.HoTen = "Tran Duc Duong";
            P6.NamSinh = 2004;
            P6.QueQuan = "Thanh Hoa";

            ThongTin P7 = new ThongTin();
            P7.HoTen = "Le Anh Tan";
            P7.NamSinh = 2003;
            P7.QueQuan = "Ha Noi";

            ThongTin P8 = new ThongTin();
            P8.HoTen = "Pham Viet Hoang";
            P8.NamSinh = 1999;
            P8.QueQuan = "Lao Cai";

            ThongTin P9 = new ThongTin();
            P9.HoTen = "Pham Quang Huy";
            P9.NamSinh = 2003;
            P9.QueQuan = "Ha Noi";

            ThongTin P10 = new ThongTin();
            P10.HoTen = "Vu Trung Hieu";
            P10.NamSinh = 2001;
            P10.QueQuan = "Ha Noi";

            ThongTin P11 = new ThongTin();
            P11.HoTen = "Nguyen Huy Hoang";
            P11.NamSinh = 2002;
            P11.QueQuan = "Ha Noi";

            /*
            Tạo biến DanhSach là 1 biến mảng với kiểu dữ liệu ThongTin.
            Khởi tạo mảng này với các phần tử, mỗi phần tử là một biến P đã tạo từ trước.
            */
            ThongTin[] DanhSach = { P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11 };

            Console.WriteLine("Thong tin hoc vien cua lop C24.05 - HB Academy"); //In ra dòng tiêu đề

            /*
            Viết 1 vòng lặp for để in ra thông tin của tất cả học viên.
            Vòng lặp for này sẽ lặp từ i = 0 đến khi i nhỏ hơn số lượng phần tử có trong mảng DanhSach, sau mỗi lần lặp i sẽ được tăng lên 1 số.
            */
            for (int i = 0; i < DanhSach.Length; i++)
			{
                /*
                In ra thông tin của từng học viên, sau khi mỗi lần in ra thành công 1 người, vòng lặp for sẽ tiếp tục lặp để hiện ra thông tin của người kế tiếp.
                */
				Console.WriteLine("{0}. Ho ten: {1} - Nam Sinh: {2} - Que Quan: {3}", i+1, DanhSach[i].HoTen, DanhSach[i].NamSinh, DanhSach[i].QueQuan);
			}

            //Dừng console để người dùng đọc nội dung console, enter để thoát console
			Console.ReadLine();

		}
	}
}

