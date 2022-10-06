/* Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
Обязательно сделать проверку на ввод чисел меньше 1 и больше 7 */

// ------------------------ПЕРВЫЙ ВАРИАНТ------------------------------
Console.WriteLine("---------------------------ПЕРВЫЙ ВАРИАНТ---------------------");
Console.WriteLine("Введите цифру обозначающую день недели: ");
int num = int.Parse(Console.ReadLine()!);

if ((num>0)&&(num<8)) {
    switch(num) {
        case 1:Console.WriteLine("Понедельник. Рабочий день."); break;
        case 2:Console.WriteLine("Вторник. Рабочий день."); break;
        case 3:Console.WriteLine("Среда. Рабочий день."); break;
        case 4:Console.WriteLine("Четверг. Рабочий день."); break;
        case 5:Console.WriteLine("Пятница. Рабочий день."); break;
        case 6:Console.WriteLine("Суббота. Выходной."); break;
        case 7:Console.WriteLine("Воскресенье. Выходной."); break;
    }
}
else
Console.WriteLine("Такого дня недели не существует.");


// ------------------------ВТОРОЙ ВАРИАНТ------------------------------
Console.WriteLine("---------------------------ВТОРОЙ ВАРИАНТ---------------------");
Console.WriteLine("Введите цифру обозначающую день недели: ");
int num1 = int.Parse(Console.ReadLine()!);

if ((num1>0)&&(num1<8)) {
    if ((num1>0)&&(num1<6)) {
        Console.WriteLine("Это рабочий день!");
    }
    else 
    Console.WriteLine("Это выходной день!");
}
else
Console.WriteLine("Такого дня недели не существует.");