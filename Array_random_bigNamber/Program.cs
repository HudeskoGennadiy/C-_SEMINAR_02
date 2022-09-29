// Напишите программу, которая выводит случайное число из отрезка[10,99] и показывает наибольшую цифру числа

    
void CompareDigits ()  
    {
    int x = new Random().Next(10 , 100);
    int x1 = x/10;
    int x2 = x%10;

    Console.WriteLine($"Сгенерированно случайное число {x} ");
    if(x1 >x2)Console.WriteLine("Первое цифра больше");
    else if (x2 >x1)Console.WriteLine("Вторая цифра больше");
    else Console.WriteLine("Это палиндром");
    }
CompareDigits();
CompareDigits();
