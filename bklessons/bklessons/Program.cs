using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("������� ���� ���: ");
            string name = Console.ReadLine();
            Console.WriteLine($"������ {name}");
            Console.ReadKey();
        }
    }

}
