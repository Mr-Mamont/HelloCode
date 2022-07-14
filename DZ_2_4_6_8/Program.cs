// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите числоЖ: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = 1;

if (b == 1)
{
    b += 1;
}
while (b <= a)
{
    Console.WriteLine(string.Join(",",b));
    b +=2;
}