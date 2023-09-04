// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System.Security.AccessControl;

Console.WriteLine("Введите значение M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

int Fun(int start, int end){
    if(start == end){
        return start;
    }
    return start + Fun(start + 1, end);
}
Console.WriteLine("" + Fun(M, N));