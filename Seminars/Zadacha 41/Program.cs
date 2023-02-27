// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// 1, -7, 567, 89, 223-> 4

 int number;
 int count=0;
string stopWord ="stop";

 while(true)
 {
    string answer=Console.ReadLine();
    if(answer==stopWord)
    {
        break;
    }
    number=Convert.ToInt32(answer);
    if( number>0) count++;
 }

Console.WriteLine(count);