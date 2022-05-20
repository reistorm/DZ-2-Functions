//Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Write("Введите число =  ");
int num = int.Parse(Console.ReadLine());

if (num > 0 && num < 100)
{
    Console.WriteLine("У числа нет третьего знака");
}
if (num > 99 && num < 1000)
{
    int thirdDigit = num % 10;
    Console.WriteLine(thirdDigit);
}
if (num > 999 && num < 10000)
{
    int numa = num / 10;
    int thirdDigit = numa % 10;
    Console.WriteLine(thirdDigit);
}
if (num > 9999 && num < 100000)
{ 
    int numb= num / 100;
    int thirdDigit = numb % 10;
    Console.WriteLine(thirdDigit);
}
if (num > 99999 && num < 1000000)
{ 
    int numb= num / 1000;
    int thirdDigit = numb % 10;
    Console.WriteLine(thirdDigit);
}

