int numberA = new int();
int numberB = new int();

Console.WriteLine("Введите первое число:");
numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB) 
{
    Console.WriteLine("Первое число является квадратом второго числа");
}

else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}

