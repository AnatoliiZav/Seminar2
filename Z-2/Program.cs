/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

652 -> 62
583 -> 53
*/

int num = new Random().Next(100, 1000);

/* Random -  случайное число */

int a1 = num / 100;
int a2 = num % 10;
int result = a1*10 + a2;
/* / - целочисленный остаток( 123 - 1), % - дробная часть(123 - 3) */


Console.Write($" число {result} из числа {num}");