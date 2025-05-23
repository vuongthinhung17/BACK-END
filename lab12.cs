//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
//using System;

//class Program
//{
//    static int TinhTongSoChan(int[] arr)
//    {
//        int tong = 0;
//        foreach (int x in arr)
//        {
//            if (x % 2 == 0)
//                tong += x;
//        }
//        return tong;
//    }

//    static void Main()
//    {
//        Console.Write("Nhap so phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        int tongChan = TinhTongSoChan(arr);
//        Console.WriteLine("Tong cac so chan trong mang: " + tongChan);
//    }
//}

//Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng.
//using System;

//class Program
//{
//    // Hàm kiểm tra số nguyên tố
//    static bool LaSoNguyenTo(int n)
//    {
//        if (n < 2) return false;
//        for (int i = 2; i <= Math.Sqrt(n); i++)
//        {
//            if (n % i == 0)
//                return false;
//        }
//        return true;
//    }

//    // Hàm hiển thị chỉ số và giá trị của các phần tử là số nguyên tố
//    static void HienThiSoNguyenTo(int[] arr)
//    {
//        Console.WriteLine("Cac phan tu la so nguyen to trong mang la:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (LaSoNguyenTo(arr[i]))
//            {
//                Console.WriteLine($"Chi so: {i}, Gia tri: {arr[i]}");
//            }
//        }
//    }

//    static void Main()
//    {
//        Console.Write("Nhap so phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        HienThiSoNguyenTo(arr);
//    }
//}

//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
//từ bàn phím.
//using System;
//class Program
//{
//    static void DemSoAmVaSoDuong(int[] arr, out int demAm, out int demDuong)
//    {
//        demAm = 0;
//        demDuong = 0;
//        foreach (int x in arr)
//        {
//            if (x > 0)
//                demDuong++;
//            else if (x < 0)
//                demAm++;
//        }
//    }
//    static void Main()
//    {
//        Console.Write("Nhap so phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        DemSoAmVaSoDuong(arr, out int soAm, out int soDuong);

//        Console.WriteLine($"So phan tu am: {soAm}");
//        Console.WriteLine($"So phan tu duong: {soDuong}");
//    }
//}

//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
//using System;

//class Program
//{
//    static int TimSoLonThuHai(int[] arr)
//    {
//        if (arr.Length < 2)
//        {
//            Console.WriteLine("Mang phai co it nhat 2 phan tu.");
//            return int.MinValue;
//        }

//        int max1 = int.MinValue;
//        int max2 = int.MinValue;

//        foreach (int x in arr)
//        {
//            if (x > max1)
//            {
//                max2 = max1;
//                max1 = x;
//            }
//            else if (x > max2 && x < max1)
//            {
//                max2 = x;
//            }
//        }

//        if (max2 == int.MinValue)
//        {
//            Console.WriteLine("Khong co so lon thu hai (cac phan tu co the giong nhau).");
//            return int.MinValue;
//        }

//        return max2;
//    }

//    static void Main()
//    {
//        int[] arr = { 5, 3, 9, 9, 7 };
//        int ketQua = TimSoLonThuHai(arr);

//        if (ketQua != int.MinValue)
//        {
//            Console.WriteLine("So lon thu hai la: " + ketQua);
//        }
//    }
//}


//Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
//using System;
//class Program
//{
//    static void HoanVi(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }

//    static void Main()
//    {
//        Console.Write("Nhap a: ");
//        int a = int.Parse(Console.ReadLine());

//        Console.Write("Nhap b: ");
//        int b = int.Parse(Console.ReadLine());

//        Console.WriteLine($"Truoc hoan vi: a = {a}, b = {b}");

//        HoanVi(ref a, ref b);

//        Console.WriteLine($"Sau hoan vi: a = {a}, b = {b}");
//    }
//}


//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
using System;

class Program
{
    static void SapXepTangDan(double[] arr)
    {
        Array.Sort(arr);
    }

    static void Main()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        // Sap xep mang tang dan
        SapXepTangDan(arr);

        Console.WriteLine("Mang sau khi sap xep:");
        foreach (double x in arr)
        {
            Console.Write(x + " ");
        }
    }
}
