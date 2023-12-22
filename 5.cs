using System;

class work_4_5
{
    static void Main()   
    {
        Console.Write("Введите a: "); // вывод инфы
        float a = float.Parse(Console.ReadLine()); // данные пользователя
        Console.Write("Введите b: "); // вывод инфы
        float b = float.Parse(Console.ReadLine()); // данные пользователя

        if (a >= -1 && a <= 3)  // если A подходит
        {
            if (b >= -2 && b <= 4) // если B подходит
            {
                Console.WriteLine("Принадлежит"); // вывод инфы
            }
            else // если B не подходит
            {
                Console.WriteLine("Не принадлежит"); // вывод инфы
            }       
        }
        else // если A не подходит
        {
            Console.WriteLine("Не принадлежит"); // вывод инфы
        }
    }
}