// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Please enter the first number");
int first_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number");
int second_num = Convert.ToInt32(Console.ReadLine());

int max = first_num;

if(max > second_num) {
    Console.WriteLine("the maximum number entered is " + max);
}
else {
    max = second_num;
    Console.WriteLine("the maximum number entered is " + max);
}