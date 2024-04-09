internal class Program
{
public static void Main(string[] args)
{
    string[] mystudents = {"Mai","An","Hao","Trung","Dung","Long"};
Console.WriteLine("Nhap 1 cai ten tu ban phim");
string name = Console.ReadLine();

bool isHas=false;
for (int i = 0; i < mystudents.Length; i++)
{
    if (mystudents[i].Equals(name))
    {
        Console.WriteLine("Co sinh vien nay");
        isHas = true;
        break;
    }
}
    if(!isHas)
    {
    Console.WriteLine("Khong co");
    }
}
}

