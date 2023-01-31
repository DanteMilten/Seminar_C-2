// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a * a == b)
{
Console.WriteLine("b квадрат a");

}else if (b * b == a){
Console.WriteLine("a квадрат b");
}else{
Console.WriteLine("не является");
}



// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());
// if((a * a) / b == 1){
// Console.WriteLine($"Число {b} является квадратом числа {a}");
// }
// else{
// Console.WriteLine($"Число {b} НЕ является квадратом числа {a}");
// }