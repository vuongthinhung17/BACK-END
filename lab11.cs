//bt2 viết ct tính S hcn khi ng dùng nhập cd và cr
double chieuDai, chieuRong, dienTich;
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