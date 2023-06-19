Console.Clear();
Console.WriteLine("Введите поочередно три различных целых числа");
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = int.Parse(Console.ReadLine());
int nummax = 0;
if(num1 > num2)
{
    nummax = num1;
}
else
{
    nummax = num2;
}
if(nummax > num3)
{
    Console.WriteLine($"Максимальное число - {nummax}");
}
else
{
    Console.WriteLine($"Максимальное число - {num3}");
}