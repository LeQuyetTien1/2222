using System;
public class Program
{   static void Main(string[] args)
    {
        int thang, nam;
        Console.WriteLine("Nhap thang: ");
        thang=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap nam: ");
        nam=Convert.ToInt32(Console.ReadLine());
        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Thang {0} nam {1} co 31 ngay",thang,nam);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Thang {0} nam {1} co 30 ngay", thang, nam);
                break;
            default:
                if (nam % 4 == 0)
                {
                    Console.WriteLine("Thang 2 nam {0} co 29 ngay", nam);
                    break;
                }
                else
                {
                    Console.WriteLine("Thang 2 nam {0} co 28 ngay", nam);
                    break;
                }
        }
    }

    
}