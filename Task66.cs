/*Задача 66: Задайте значения M и N. Напишите 
программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N. Выполнить с помощью рекурсии.
*/

Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());


void SumNaturalNumbers (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumNaturalNumbers(numberM, numberN, sum);
}

SumNaturalNumbers(numberM, numberN, 0);
