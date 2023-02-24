//  Напишите программу, которая по заданному номеру
//  четверти, показывает диапазон возможных координат
//  точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите номер четверти ");
int ch1 = int.Parse(Console.ReadLine()!);


if (ch1 == 1)
{
Console.Write("X>0 , Y>0 ");
}
else if (ch1 == 2)
{
Console.Write("X<0 , Y>0 ");
}
else if (ch1 == 3 )
{
Console.Write("X<0 , Y<0 ");
}
else if (ch1 == 4 )
{
Console.Write("X>0 , Y<0 ");
}
else
{
Console.Write("Ввкдите число от 1 до 4 ");
}