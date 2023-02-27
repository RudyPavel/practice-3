int number = Convert.ToInt32(Console.ReadLine());
int ostatok, sum = 0;
int temp = number;

while (number > 0)
{
    ostatok = number % 10;
    
    sum = (sum * 10) + ostatok;
    
    number = number / 10;
}

if (temp == sum)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}