using System;

namespace BBVBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            bool Work = true;
            Console.WriteLine("--> Открыть счёт" + " \nВнести деньги" + "\nСнять деньги" + "\nПеревести деньги" + "\nВзять кредит" + "\nПомощь" + "\nАвторы" + "\nБаланс" + "\nВыход" + "\n\n" + "Для выбора нажмите Z");
            while (Work == true)
            {
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'w' || key == 'W' || key == 'ц' || key == 'Ц')
                {
                    m--;
                }
                if (key == 's' || key == 'S' || key == 'ы' || key == 'Ы')
                {
                    m++;
                }

                if (m == 10)
                {
                    m = 1;
                }
                if (m == 0)
                {
                    m = 9;
                }
                if (m == 1)
                {
                    Console.Clear();
                    Console.WriteLine("--> Открыть Счёт");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Открыть Счёт");
                }
                if (m == 2)
                {
                    Console.WriteLine("--> Внести деньги");
                }
                else
                {
                    Console.WriteLine("Внести деньги");
                }
                if (m == 3)
                {
                    Console.WriteLine("--> Снять деньги");
                }
                else
                {
                    Console.WriteLine("Снять деньги");
                }
                if (m == 4)
                {
                    Console.WriteLine("--> Перевести деньги");
                }
                else
                {
                    Console.WriteLine("Перевести деньги");
                }
                if (m == 5)
                {
                    Console.WriteLine("--> Взять кредит");
                }
                else
                {
                    Console.WriteLine("Взять кредит");
                }
                if (m == 6)
                {
                    Console.WriteLine("--> Помощь");
                }
                else
                {
                    Console.WriteLine("Помощь");
                }
                if (m == 7)
                {
                    Console.WriteLine("--> Авторы");
                }
                else
                {
                    Console.WriteLine("Авторы");
                }
                if (m == 8)
                {
                    Console.WriteLine("--> Баланс ");
                }
                else
                {
                    Console.WriteLine("Баланс");
                }
                if (m == 9)
                {
                    Console.WriteLine("--> Выход" + "\n\n" + "Для выбора нажмите Z");
                }
                else
                {
                    Console.WriteLine("Выход" + "\n\n" + "Для выбора нажмите Z");
                }

                if (m == 1 && key == 'z' || key == 'Z' || key == 'я' || key == 'Я')
                {
                    Account account = new Account();
                    Account.acc = true;
                    Console.Clear();
                    Console.WriteLine("Ваш счёт успешно создан." + "\n\nДля продолжения нажмите любую клавишу...");
                }
                if (m == 9 && key == 'z' || key == 'Z' || key == 'я' || key == 'Я')
                {
                    Work = false;
                }
                if (m == 8 && key == 'z' || key == 'Z' || key == 'я' || key == 'Я')
                {
                    if (Account.acc == true)
                    {
                        Console.Clear();
                        Console.WriteLine(Account.money + "\n\nДля продолжения нажмите любую клавишу...");
                    }
                    if (Account.acc == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Требуется открыть счёт." + "\n\nДля продолжения нажмите любую клавишу...");
                    }
                }
                
            }
        }
    }
}
