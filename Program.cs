using System;

namespace BaiTH;

class Baitap
{
    static void Main(string[] args)
    {
        new Baitap().Bai1();
        new Baitap().Bai2();
        new Baitap().Bai3();
        new Baitap().Bai4();
        new Baitap().Bai5();
        new Baitap().Bai6();
    }
    void Bai1()
    {
        Console.WriteLine("Bai 1:");
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] Array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ptu thu {i + 1}: ");
            Array[i] = int.Parse(Console.ReadLine());
        }

        int Sum = 0;
        foreach (int i in Array)
        {
            Sum += i;
        }

        Console.WriteLine("Tong cua mang: {0} ", Sum);
    }
    

    void Bai2()
    {
        Console.WriteLine("Bai 2:");
        Console.WriteLine("Nhap chuoi ki tu:");
        string n = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < n.Length; i++)
        {
            char c = n[i];
            if (char.IsLetterOrDigit(c))
            {
                count++;
            }
        }
        Console.WriteLine("So luong ky tu la: " + count);
    }

    void Bai3()
    {
        Console.WriteLine("Bai 3:");
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ptu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array[0];

        for (int i = 1; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
    }



    void Bai4()
    {
        Console.WriteLine("Bai 4:");
        Console.WriteLine("Nhap chuoi ki tu:");
        string n = Console.ReadLine();

        string daonguoc = "";
        for (int i = n.Length - 1; i >= 0; i--)
        {
            daonguoc += n[i];
        }

        Console.WriteLine("Chuoi dao nguoc la: " + daonguoc);
    }



    void Bai5()
    {
        Console.WriteLine("Bai 5:");
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];


        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ptu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (array[i] != array[n - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Mang la doi xung .");
        }
        else
        {
            Console.WriteLine("Mang khong phai la doi xung .");
        }
        
    }
    s


    void Bai6()
    {
        Console.WriteLine("Bai 6:");
        Console.WriteLine("Nhap chuoi ki tu:");
        string n = Console.ReadLine();

        Console.WriteLine("Nhap ky tu can dem:");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int count = 0;

        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] == ch)
            {
                count++;
            }
        }

        Console.WriteLine($"Ky tu '{ch}' xuat hien {count} lan trong chuoi.");
    }
}