/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
одновременно 7 и 23.
*/

System.Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

//метод один
/*if (userNumber % 7 == 0)
{
    if (userNumber % 23 == 0)
    System.Console.WriteLine($"Число {userNumber} кратно одновременно 7 и 23");
}*/

//метод два 
if (userNumber % 7 == 0 && userNumber % 23 == 0)
    System.Console.WriteLine($"Число {userNumber} кратно одновременно 7 и 23");
else
    System.Console.WriteLine($"Число {userNumber} некратно одновременно 7 и 23");

