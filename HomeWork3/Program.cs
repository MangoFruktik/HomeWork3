#region Задание 1
using System;

int number;

Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine()); //Не могу понять как уйти от значения NULL. Каким образом организовать проверку на NULL.

    if (number % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число не четное");
    }
    Console.WriteLine("Для перехода к следующему заданию нажмите Enter...");
    Console.ReadKey();
#endregion

#region Задание 2

int value;
int value_cart = 0;
int sum = 0;

Console.WriteLine("\nДобро пожаловать! \nВведите количество ваших карт: ");
value = Convert.ToInt32(Console.ReadLine());

if (value > 0) 
{
    for (int i = 1; i <= value; i++)
    {
        Console.WriteLine($"Введите номинал {i} карты");
        value_cart = Convert.ToInt32(Console.ReadLine());//Нет понимания каким образом тут использовать switch
        sum += value_cart;                               //И каким образом преобразовать нажатие клавиши J или T в то значение которое нужно.
    }                                                    // Нашел в справке ConsoleKey.? но как его правильно использовать пока так и не понял. 
    Console.WriteLine($"Сумма всех карт равна - {sum}");
}
else
{
    Console.WriteLine("Карт не может быть меньше 0");
}

Console.WriteLine("Для перехода к следующему заданию нажмите Enter...");
Console.ReadKey();

#endregion

#region Задание 3

bool prime_number = true;
int j = 2;
int n;

Console.WriteLine("\nВведите целое число: ");
n = int.Parse(Console.ReadLine());

while (j <= n / 2)
{
    j++;
    if (n % j == 0)
    {
        prime_number = false;
        break;
    }
}
    if (prime_number == true)
    {
        Console.WriteLine("Число простое");
    }
    else
    {
        Console.WriteLine("Число не простое");
    }
Console.ReadKey();

#endregion