Console.Write("Введите номер дня (1-7): ");
int num1 = Convert.ToInt32(Console.ReadLine());
 
 switch(num1)
 {
    case 1:
    Console.WriteLine("Понедельник");
    break;
    
    case 2:
    Console.WriteLine("Вторник");
    break;
    
    case 3:
    Console.WriteLine("Среда");
    break;
    
    case 4:
    Console.WriteLine("Четверг");
    break;
    
    case 5:
    Console.WriteLine("Пятница");
    break;
    
    case 6:
    Console.WriteLine("Суббота");
    break;
     
    case 7:
    Console.WriteLine("Воскресенье");
    break;

    default:
    Console.WriteLine("Число не входит в диапозон 1..7 ");
    break;
}
switch(num1)
 {
    case 1:
    Console.WriteLine("Рабочий день");
    break;
    
    case 2:
    Console.WriteLine("Рабочий день");
    break;
    
    case 3:
    Console.WriteLine("Рабочий день");
    break;
    
    case 4:
    Console.WriteLine("Рабочий день");
    break;
    
    case 5:
    Console.WriteLine("Рабочий день");
    break;
    
    case 6:
    Console.WriteLine("Выходной");
    break;
     
    case 7:
    Console.WriteLine("Выходной");
    break;

    default:
    Console.WriteLine("Число не входит в диапозон 1..7 ");
    break;
 }