// Урок 1. Знакомство с языком программирования С#
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Please enter the first number");
int first_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number");
int second_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the third number");
int third_num = Convert.ToInt32(Console.ReadLine());

int max = first_num;

if(max < second_num) {
    max = second_num;
}
if (max < third_num) {
     max = third_num;
}

Console.WriteLine("the maximum number entered is " + max);