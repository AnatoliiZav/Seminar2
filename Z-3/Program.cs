Console.WriteLine("Введите первое число : ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int N2 = int.Parse(Console.ReadLine());

int result = N1 % N2;
/* можно убрать int result = N1 % N2; , тогда if (N1 % N2 == 0) */

if (result == 0)
{
    Console.Write($"{N1} кратно {N2}");
}
else
{
    Console.Write($"{N1} не кратно {N2}, остаток {result}"); /* тогда здесь вместо result пишем N1 % N2 */
}
