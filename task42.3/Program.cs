int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string Conv(int number)
{
    string result = "";
    int tmp = 0;
    for (int i = number; i > 0; i/=2)
    {
        tmp = i % 2;
        result = tmp + result;
    }
    return result;
}

int uNum = UserInOut("Введите число: ");
System.Console.WriteLine(Conv(uNum));