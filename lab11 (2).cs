//b1 Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
//[tên], bạn[tuổi] tuổi!".
using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap ten cua ban: ");
        string ten = Console.ReadLine();

        Console.Write("Nhap tuoi cua ban ");
        string tuoiStr = Console.ReadLine();

        // Chuyển đổi chuỗi tuổi sang số nguyên
        int tuoi;
        if (int.TryParse(tuoiStr, out tuoi))
        {
            Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
        }
        else
        {
            Console.WriteLine("Tuoi ban nhap khong hop le.");
        }
    }
}
//bt2 viết ct tính S hcn khi ng dùng nhập cd và cr
/*double chieuDai, chieuRong, dienTich;
try
{
Console.WriteLine("Nhap chieu dai: ");
chieuDai = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Nhap chieu rong: ");
chieuRong = double.Parse(Console.ReadLine() ?? "");
//tính dtich
dienTich = chieuDai * chieuRong;
    if (chieuDai <= 0 || chieuRong <= 0)
        throw new Exception("Do dai phai lon hon 0");
    //tung ngoại lệ cướng bức
Console.WriteLine($"ien tich; {dienTich}");
}
catch(FormatException ex)
{
    Console.WriteLine($"Loi nhap lieu: {ex.Message}");
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}
*/
//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
//Công thức: F = (C * 9 / 5) + 32
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập nhiệt độ (°C): ");
        string input = Console.ReadLine();

        // Chuyển đổi chuỗi nhập vào thành số thực
        double celsius = double.Parse(input);

        // Công thức chuyển đổi
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"{celsius}°C bằng {fahrenheit}°F");
    }
}
*/
//b4:Kiểm tra số chẵn
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập vào một số nguyên: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine($"{number} là số chẵn.");
        else
            Console.WriteLine($"{number} là số lẻ.");
    }
}
/*
//b5:Tính tổng và tích hai số
/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());

        int tong = a + b;
        int tich = a * b;

        Console.WriteLine($"Tổng = {tong}");
        Console.WriteLine($"Tích = {tich}");
    }
}*/
//Bài 6: Kiểm tra số dương, âm hoặc không
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập vào một số: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
            Console.WriteLine($"{number} là số dương.");
        else if (number < 0)
            Console.WriteLine($"{number} là số âm.");
        else
            Console.WriteLine("Số vừa nhập là số 0.");
    }
}*/
//Bài 7: Kiểm tra năm nhuận
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập vào một năm: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine($"{year} là năm nhuận.");
        else
            Console.WriteLine($"{year} không phải là năm nhuận.");
    }
}*/
//Bài 8: In bảng cửu chương từ 1 đến 10
/*using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nBảng cửu chương {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }
}*/
//Bài 9: Tính giai thừa của n
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập vào số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        long giaiThua = 1;

        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }

        Console.WriteLine($"{n}! = {giaiThua}");
    }
}*/
//Bài 10: Kiểm tra số nguyên tố

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap vao mot so nguyen: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (number < 2)
            isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine($"{number} la so nguyen to.");
        else
            Console.WriteLine($"{number} khong phai la so nguyen to .");
    }
}
*/