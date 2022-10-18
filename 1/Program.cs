Console.WriteLine("Введите натуральное число > 1:");
int number = int.Parse(Console.ReadLine());


void NumberCounter (int number)
{
    if (number < 0) Console.WriteLine($"{number} не натуральное число");
    if (number == 0) return;
    
    Console.WriteLine("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);
