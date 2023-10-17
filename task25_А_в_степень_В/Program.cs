/*
Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("Введите число:");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень числа:");
int userB = Convert.ToInt32(Console.ReadLine());

while (userB < 1)
{
    System.Console.WriteLine("Степень не натуральное число!");
    System.Console.WriteLine("Введите степень числа:");
    userB = Convert.ToInt32(Console.ReadLine());
}

/*if (userB < 1)
    System.Console.WriteLine("Степень не натуральное число!");

else
{*/
double PowerUp(int a, int b)
{
    double result = 1;
    if (b > 0)

    {
        for (int i = 0; i < b; i++)
        {
            result = result * a;
        }
    }
    /*else if (b < 0)
    {
        b = b * -1;
        for (int i = 0; i < b; i++)
        {
            result = result / a;
        }
    }*/
    return result;
}

double userResult = PowerUp(userA, userB);
System.Console.WriteLine($"{userA}, {userB} -> {userResult}");
//}