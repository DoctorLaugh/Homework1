Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());
int res = num%10;
Console.WriteLine(res);