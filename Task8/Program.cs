Console.Clear();
Console.WriteLine("Введите целое число больше 1");
int num=int.Parse(Console.ReadLine());
int count = 1;
while(count<=num)
{
    if(count%2 == 0)
    {
        Console.Write($"{count} ");
    }
count++;
}