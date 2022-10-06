/*Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет. Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000) */

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int num = number;

if (num>99) {
    if (number<=100000) {
        while (num>1000) {
            num = num/10;
        }
    num = num%10;
    Console.WriteLine($"Введённое число {number}. Третья цифра числа {num}.");
    }
    else {
    Console.WriteLine("Введите значение меньше 100000.");
    }
}
else
Console.WriteLine($"В введенном числе {number} нет третьей цифры.");