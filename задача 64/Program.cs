// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string Fun(int min, int max){
    if (min == max){
        return "" + max;
    }
    return max + " " + Fun(min, max - 1);
}
Console.WriteLine(Fun(1, a));