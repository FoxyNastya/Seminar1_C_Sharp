// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).//  Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

int b = a*a;
Console.WriteLine(b);

