public class Program
{
    public static void Main(string[] args)
    {
        float rate = 23000; // Tỷ giá USD sang VND
        Console.WriteLine("Chuyển đổi tiền tệ");
        Console.WriteLine("Nhập vào số tiền cần chuyển đổi");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Số tiền đã nhập: " + amount);
        Console.WriteLine("Tỷ giá chuyển đổi: " + rate);
        Console.WriteLine("Tiền sau khi chuyển đổi: " + amount * rate);

    }
}