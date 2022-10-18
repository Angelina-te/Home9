onsole.Write("Число M:  ");
int m = Convert.ToInt32(Console.ReadLine());


Console.Write("Число N:  ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);



void AkkermanFunction(int m, int n)
{
    Console.WriteLine(Akkerman(m, n)); 
}


//функции
int Akkerman(int m, int n)

{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
