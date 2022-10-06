/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем */

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int num1 = number/10;
int num2 = num1%10;
if (number>99 && number<1000) {
    Console.WriteLine($"Введенное число {number}. Вторая цифра числа - {num2}.");
}
else 
Console.WriteLine("Вы ввели некорректное число.");