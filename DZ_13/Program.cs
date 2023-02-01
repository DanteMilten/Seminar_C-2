// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Первое решение не полное есть ошибка, второе решение мне помогли, но он сложное, я очень плохо его понял

// Console.Clear();
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// string number3rd = Convert.ToString(number[2]);
// Console.WriteLine ($"третья цифра от {number} -> {number3rd}");
// if (number.Length < 2)
// {
//     Console.WriteLine($"{number} -> третьей цифры нет");
// }

Console.Clear();
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
 if (b < 3)
    {
 Console.Write("Третьей цифры нет ");
    }
 else
    {
 int c = 1;
 for (int i = b; i > 3; i--)
        {
 c = c * 10;
        }

 result = (a / c) % 10;
    }
return result;
}