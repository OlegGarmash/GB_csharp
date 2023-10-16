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

double PowerUp(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

double userResult = PowerUp(userA, userB);
System.Console.WriteLine($"{userA}, {userB} -> {userResult}");
