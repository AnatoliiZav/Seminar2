Console.WriteLine("Введите первое число : ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int N2 = int.Parse(Console.ReadLine());



if (N1 * N1  == N2 || N2 * N2 == N1) /* "||" логическая "или" - делает проверку  на истину */
    {
         Console.Write("да");
    }
        
else
{Console.Write("нет"); 
} 

