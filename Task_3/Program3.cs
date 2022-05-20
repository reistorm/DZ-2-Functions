//Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

int num = new Random().Next(1, 8);
Console.WriteLine("День -  " + num);
if (num == 6 || num == 7) Console.WriteLine("Выходной день");
else Console.WriteLine("Рабочий день");

