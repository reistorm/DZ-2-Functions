//Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

int num = new Random().Next(1, 8);
Console.WriteLine("День -  " + num);
if (num == 6 || num == 7) Console.WriteLine("Выходной день");
else Console.WriteLine("Рабочий день");

//Если вводить числа, соответствующие дням недели,
//то программа будет такой

Console.Write("Введите число, соответствующее дню недели = ");
int num1 = int.Parse(Console.ReadLine());
if (num1 == 6 || num1 == 7) Console.WriteLine("Выходной день");
else if (num1 > 0 && num1 < 6) Console.WriteLine("Рабочий день");
else if (num1 > 7) Console.WriteLine("Такого дня не существует");