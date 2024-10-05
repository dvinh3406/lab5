internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap diem trung binh cua sinh vien");
        float score = float.Parse(Console.ReadLine());
        if ( 0 <=score&&score<5) Console.WriteLine("yeu");
        else if ( 5 <=score&&score<7) Console.WriteLine("trung binh");
        else if ( 7 <=score&&score<8) Console.WriteLine("kha");
        else if ( 8 <=score&&score<10) Console.WriteLine("gioi");
        else Console.WriteLine("nhap sai gia tri diem so");
    }
}