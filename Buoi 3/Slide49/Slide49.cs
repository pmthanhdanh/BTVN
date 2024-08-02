using System;
namespace BTVN_Buoi3 //Tạo namespace BTVN_Buoi3
{
	public class Slide49 //Tạo lớp Slide49
	{
		static void Main49() //Tạo phương thức Main
        {   /*
            - Dòng đầu tiên chứa tiêu đề các cột
            - Các dòng còn lại chứa các thông số
            - Ý nghĩa {0,-15}: 0 là chỉ số của đối số, -15 là độ rộng tối thiểu của trường đối số,
            nếu giá trị đối số ít hơn 15 ký tự thì sẽ tự động thêm khoảng trắng vào để cho đủ 15 ký tự. 
            */
			Console.WriteLine("{0,-15} {1,-7} {2,-15} {3,-7} {4,-15} {5,10}", "City", "Year", "Population", "Year", "Population", "Change (%)\n");
            Console.WriteLine("{0,-15} {1,-7} {2,-15} {3,-7} {4,-15} {5,10}", "Los Angeles", "1940", "1.504.277", "1950", "1.970.358", "31.0%");
            Console.WriteLine("{0,-15} {1,-7} {2,-15} {3,-7} {4,-15} {5,10}", "New York", "1940", "7.454.995", "1950", "7.891.957", "5.9%");
            Console.WriteLine("{0,-15} {1,-7} {2,-15} {3,-7} {4,-15} {5,10}", "Chicago", "1940", "3.396.808", "1950", "3.628.962", "6.6%");
            Console.WriteLine("{0,-15} {1,-7} {2,-15} {3,-7} {4,-15} {5,10}", "Detroit", "1940", "1.623.452", "1950", "1.849.568", "13.9%");

            //Pause Console
            Console.ReadLine();
        }
    }
}

