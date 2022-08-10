Console.WriteLine("Введите первое число : ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int N2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число : ");
int N3 = int.Parse(Console.ReadLine());


int result = N1 % N2;
int result1 = N1 % N3;

if (result  == 0 && result1 == 0)
    {
         Console.Write($"{N1} кратно {N2} и {N3}");
    }
        
else
{Console.Write($"{N1} не кратно одновременно {N2} и {N3}"); 
} 
