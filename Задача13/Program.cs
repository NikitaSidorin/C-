Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int amount = num.ToString().Length;

if (amount < 3 || amount > 3)
{
     Console.WriteLine("Нет третьей цифры");
}
else
{  
     int secondnum = (num  % 10 );
     Console.WriteLine(secondnum);
}
