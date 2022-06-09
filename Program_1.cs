// 

int num = new Random().Next(10, 100);

Console.WriteLine(num);

int c1 = num / 10;  // 56 / 10 = 5 (первая цифра слева)
int c2 = num % 10;  // (остаток, вторая цифра)

if (c1 < c2)
{
    Console.WriteLine(c2);
}
else 
{
    Console.WriteLine(c1);
}
