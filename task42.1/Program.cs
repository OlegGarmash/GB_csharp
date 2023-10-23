Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ToBinary( int number)
{
    int result= 0;
    int ten = 1;
    while(number>0){
        result=number%2*ten+result;
        number=number/2;
        ten=ten*10;
    }
return result;
}
int Number = ToBinary(number);
Console.Write(Number);