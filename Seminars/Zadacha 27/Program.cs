// Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 
// 82 -> 10 
// 9012 -> 12


// Console.Clear();
// Console.WriteLine("Enter number: ");
// int N = int.Parse(Console.ReadLine()!);
// int K = N % 10;
// int Sum = K;
// while (N != 0)
// {
// N /= 10;
// K = N % 10;
// Sum = Sum + K;
// }
// Console.WriteLine($"{Sum}"!);

int Readnumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int a)
{
    int sum=0;

    while (a!=0)
    {
        sum=sum+a%10;
        a=a/10;
    }
    return sum;
}

int number = Readnumber("Введите число: ");
int SumAllNumbers=SumNumbers(number);
Console.WriteLine(SumAllNumbers);