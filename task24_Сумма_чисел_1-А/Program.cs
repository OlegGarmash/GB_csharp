/*
Напишите программу, которая принимает на вход число (А) и
выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 ->36
*/

System.Console.WriteLine("Введите число A:");
int userA = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int result = 0;
    for (int i = 0; i <= a; i++)
    {
        result = result + i;
    }
    return result;
}

int userResult = Num(userA);
System.Console.WriteLine($"{userA} -> {userResult}");
