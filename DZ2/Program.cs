/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое чиcло");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе чиcло");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье чиcло");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max)
    {
        max = num2;
    }

    if (num3 > max)
        {
            max = num3;
        }

Console.WriteLine("Наибольшее из введённых чисел -> " + max);