//Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int firstDigit = num / 10;
int secondDigit = firstDigit % 10;
Console.WriteLine(secondDigit);
