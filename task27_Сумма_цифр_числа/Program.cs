/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("Введите число:");
int userA = Convert.ToInt32(Console.ReadLine());

int Sum(int a)
{
    int result = 0;
    if (a < 0) a = a * -1;
    for (int i = a; i > 0; i /= 10)
    {
        result = result + a % 10;
        a /= 10;
    }
    return result;
}

double userResult = Sum(userA);
System.Console.WriteLine($"{userA} -> {userResult}");