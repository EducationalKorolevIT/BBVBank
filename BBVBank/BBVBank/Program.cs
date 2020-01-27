using System;

namespace BBVBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            char key = Console.ReadKey(true).KeyChar;
            Console.WriteLine("--> Создать аккаунт");
            if (key == 'w')
            {
                m++;
            }
            if(m == 1)
            {
                Console.Clear();
                Console.WriteLine("--> Создать аккаунт");
            }
            else
            {
                Console.WriteLine("Создать аккаунт");
            }
        }
    }
}
