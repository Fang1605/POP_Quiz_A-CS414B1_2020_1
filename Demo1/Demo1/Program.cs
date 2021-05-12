using System;

namespace Demo1
{
    class Program
    {
        void check(int ngay)
        {
            DateTime today = DateTime.Now;
            int ngays = Convert.ToInt32(today.Day);
            if( ngay == ngays)
            {
                Console.WriteLine("Happy brithday");
            }
        }
        static void Main(string[] args)
        {
            Program A = new Program();
            Console.WriteLine("Nhap ten");
            String name = Console.ReadLine();
            Console.WriteLine("Nhap day sinh");
            String ngay = Console.ReadLine();
            int ngays = int.Parse(ngay);
            Console.WriteLine("Nhap tuoi");
            String tuoi = Console.ReadLine();
            int age = int.Parse(tuoi);
            Console.WriteLine("Ten "  + name + "; ngay sinh " + ngays+ "; tuoi "+age);
            A.check(ngays);
            Console.ReadKey();

        }
    }
}
