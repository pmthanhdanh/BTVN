using System;
using System.IO; // Thêm using System.IO để sử dụng File.WriteAllText

namespace BTVN_Buoi3 //Tạo namespace BTVN_Buoi3
{
	public class Slide56 //Tạo lớp Slide56
	{
		static void Main() //Tạo phương thức Main
		{
			int x, y, z; //Tạo 3 biến X, Y, Z với kiểu dữ liệu INT

			Console.WriteLine("Nhap vao so nguyen X: "); //In ra dòng thông báo
			x = int.Parse(Console.ReadLine()); //Nhập dữ liệu từ bàn phím vào biến X
            Console.WriteLine("Nhap vao so nguyen Y: "); //In ra dòng thông báo
            y = int.Parse(Console.ReadLine()); //Nhập dữ liệu từ bàn phím vào biến Y
            Console.WriteLine("Nhap vao so nguyen Z: "); //In ra dòng thông báo
            z = int.Parse(Console.ReadLine()); //Nhập dữ liệu từ bàn phím vào biến Z

            //Tạo biến Dong1 với kiểu dữ liệu STRING, giá trị biến là 1 chuỗi được kết hợp từ 3 biến X - Y - Z, cách nhau bởi 1 dấu trắng
            string Dong1 = $"{x} {y} {z}";

            //Tạo biến Dong2_Delta với kiểu dữ liệu INT, giá trị biến là phép toán tính Delta
			int Dong2_Delta = y * y - 4 * x * z;

            //Tạo 1 biến KetQuaNghiem với kiểu dữ liệu STRING, giá trị mặc định là NULL
            string KetQuaNghiem = null;

            //Dùng câu lệnh điều kiện IF để tính 2 nghiệm phân biệt
            if (Dong2_Delta > 0) //Nếu Delta lớn hơn 0
			{
                //Tạo biến Dong3_Nghiem1 với kiểu dữ liệu Double. Giá trị của nó là kết quả của phép toán tính nghiệm phân biệt 1
				double Dong3_Nghiem1 = (-y + Math.Sqrt(Dong2_Delta)) / (2 * x);
                //Tạo biến Dong4_Nghiem2 với kiểu dữ liệu Double. Giá trị của nó là kết quả của phép toán tính nghiệm phân biệt 2
                double Dong4_Nghiem2 = (-y - Math.Sqrt(Dong2_Delta)) / (2 * x);
                //Gán giá trị cho biến KetQuaNghiem, với dòng 3 là kết quả Nghiệm 1 và dòng 4 là kết quả Nghiệm 2
				KetQuaNghiem = $"{Dong3_Nghiem1}\n{Dong4_Nghiem2}";
			}

            //Dùng câu lệnh điều kiện IF để tính nghiệm kép
            if (Dong2_Delta == 0) //Nếu Delta bằng 0
            {
                //Tạo biến Dong3_Nghiem1 với kiểu dữ liệu Double. Giá trị của nó là kết quả của phép toán tính nghiệm kép
                double Dong3_Nghiem1 = -(y / (2 * x));
                //Tạo biến Dong4_Nghiem2 với kiểu dữ liệu Double. Giá trị của nó là kết quả của phép toán tính nghiệm kép
                double Dong4_Nghiem2 = -(y / (2 * x));
                //Gán giá trị cho biến KetQuaNghiem, với dòng 3 là kết quả Nghiệm kép và dòng 4 là kết quả Nghiệm kép
                KetQuaNghiem = $"{Dong3_Nghiem1}\n{Dong4_Nghiem2}";
            }

            //Nếu Delta nhỏ hơn 0 thì sẽ không có nghiệm, không có dòng 3 và dòng 4 được ghi vào file

            //Tạo biến NoiDungGhiVaoFile với kiểu dữ liệu STRING, giá trị biến là 1 chuỗi được kết hợp từ 3 biến Dong1 - Dong2_Delta - KetQuaNghiem, mỗi biến nằm ở 1 dòng riêng biệt
            string NoiDungGhiVaoFile = $"{Dong1}\n{Dong2_Delta}\n{KetQuaNghiem}";

            //Câu lệnh đưa dữ liệu của biến NoiDungGhiVaoFile vào file output.txt
			File.WriteAllText("output.txt", NoiDungGhiVaoFile);

        }
	}
}

