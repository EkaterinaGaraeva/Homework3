/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int letter1 = number / 10000;
int letter2 = number / 1000;
letter2 = letter2 % 10;
int letter4 = number / 10;
letter4 = letter4 % 10;
int letter5 = number % 10;

/*
Console.WriteLine(letter1);
Console.WriteLine(letter2);
Console.WriteLine(letter4);
Console.WriteLine(letter5);
*/

if (letter1 == letter5 && letter2 == letter4)
{
    Console.WriteLine($"Число {number} явлется палиндромом");
}

else
{
    Console.WriteLine($"Число {number} не явлется палиндромом");
}