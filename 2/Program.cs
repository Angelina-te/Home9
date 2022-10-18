Console.Write("Начальное число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Начальное число M: ");
int numberN = int.Parse(Console.ReadLine());


void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.Write($"Сумма элементов в промежутках  M до N: {sum}" ); 
       
        return;
    }
    
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);