using System;
namespace BTVN_Buoi3 //Tạo namespace BTVN_Buoi3
{
	public class Slide51 //Tạo lớp Slide51
	{
		static void Main() //Tạo phương thức Main
		{
			char input_char; //Tạo biến input_char với kiểu dữ liệu char
			Console.WriteLine("Nhap vao 1 ky tu: "); //Hiển thị ra thông báo
			input_char = char.Parse(Console.ReadLine()); //Nhận dữ liệu nhập vào từ bàn phím, gán cho biến input_char

            //Tạo biến char_num với kiểu dữ liệu INT, gán giá trị cho nó là phép chuyển kiểu từ char qua int của input_char
            int char_num = (int)input_char;
            //Hiển thị ra kết quả từ Ký tự thành Mã Unicode
            Console.WriteLine("\nKy tu ban da nhap la: {0} - Ma Unicode: {1}", input_char, char_num);

			Console.WriteLine("---");

			int input_char_num; //Tạo biến input_char_num với kiểu dữ liệu int
			Console.WriteLine("\nNhap ma Unicode: "); //Hiển thị ra thông báo
			input_char_num = int.Parse(Console.ReadLine()); //Nhận dữ liệu nhập vào từ bàn phím, gán cho biến input_char_num

            //Tạo biến input_char_num_conv với kiểu dữ liệu char, gán giá trị cho nó là phép chuyển kiểu từ int qua char của input_char_num
            char input_char_num_conv = (char)input_char_num;
            //Hiển thị ra kết quả từ Mã Unicode chuyển ngược thành Ký tự
            Console.WriteLine("\nMa Unicode ban da nhap la: {0} - Ky tu duoc dich la: {1}", input_char_num, input_char_num_conv);

            Console.WriteLine("---");

			Console.WriteLine("\nBang Ma Unicode"); //Hiển thị ra thông báo
			Console.WriteLine("{0} {1,10}", "Ma", "Ky Tu"); //Hiển thị ra dòng có 2 cột là Mã và Ký tự

			//Tạo vòng lặp for để hiển thị ra kết quả 2 cột Mã và Ký tự. Vòng lặp bắt đầu từ i là 0, và kết thúc là i = 254
			for(int i = 0; i < 255; i++)
			{
				//Tạo biến uni_char với kiểu dữ liệu là char, gán giá trị cho nó là phép chuyển kiểu từ int qua char của i
				char uni_char = (char)i;

				//Hiển thị ra từng dòng kết quả, gồm 2 cột là Mã Unicode (từ 0 - 255) và Ký tự chuyển từ Mã Unicode
				Console.WriteLine("{0} {1,10}", i, uni_char);
			}

			//Pause console
            Console.ReadLine();
		}
	}
}

