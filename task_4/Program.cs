// Урок 1. Знакомство с языком программирования С#
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Please enter the number");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) {
    num = num * -1;
}
else if (num == 0) {
    Console.WriteLine("The number is 0");  
}

int count = 0;

while (count <= num)
{
    if ((count > 0) && (count % 2 == 0))
    {
        Console.Write(count + "  ");
        count++;
    }
    else
    {
        count++;
    }
}

