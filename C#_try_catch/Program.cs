// Функция (try catch)

Console.Write("Введите целое число: ");
try
    {
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(x * 10);
    }

catch
{
    Console.WriteLine("Нужно было вводить целое число");
}


