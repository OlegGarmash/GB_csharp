/*
Напишите программу, которая принимает на вход число и 
выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

System.Console.WriteLine("Введите число A:");
int userA = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int count = 0;
    if (a == 0) count = 1;
    if (a < 0) a = a * -1;

    for (int i = a; i > 0; i /= 10)
    {
        count++;
    }
    return count;
}

int userResult = Num(userA);
System.Console.WriteLine($"{userA} -> {userResult}");