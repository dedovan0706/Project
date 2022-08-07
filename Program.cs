while (true)
{
    Console.WriteLine("Введите оператор +/-/*/: или end для выхода");
    string Operator = Console.ReadLine();
    if (Operator == "end")
    {
        break;
    }
    Console.WriteLine("Введите число 1 ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 2 ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (Operator == "+")
    {
        Console.WriteLine("Мы сложили числа");
        Console.WriteLine(number1 + number2);
    }
    else if (Operator == "-")
    {
        Console.WriteLine("Мы вычли числа");
        Console.WriteLine(number1 - number2);
    }
    else if (Operator == "*")
    {
        Console.WriteLine("Мы умножили числа");
        Console.WriteLine(number1 * number2);
    }
    else if (Operator == ":")
    {
        Console.WriteLine("Мы разделили числа");
        Console.WriteLine(number1 / number2);
    }
    
    
}




