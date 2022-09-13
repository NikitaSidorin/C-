Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int amount = num.ToString().Length;

if (amount < 3 || amount > 3)
{
     Console.WriteLine("Вы ввели не трехзначное число");
}
else
{  
     int secondnum = ((num / 10) % 10 );
     Console.WriteLine(secondnum);
}

