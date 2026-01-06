using System.Data.SqlTypes;

public static class calculator
{
    public static void Run()
    {
        Console.WriteLine("Введите первое число: ");

        if (!double.TryParse(Console.ReadLine(), out double b)) {
            Console.WriteLine("Ошибка ввода");

        }
        Console.WriteLine("Введите операцию (* / + - ): ");
        string op = Console.ReadLine();

        Console.WriteLine("Введите второе число: ");
        if (!double.TryParse(Console.ReadLine(), out double c))
        {
            Console.WriteLine("Ошибка ввода");
        }
        double result;
        switch (op)
        {
            case "+":
                result = b + c; break;
            case "-":
                result = b - c; break;
            case "*":
                result = b * c; break;
            case "/":
                result = b / c; break;
                if (c == 0)
                {
                    Console.WriteLine("на 0 делить нельзя!");
                    return;
                }
            default:
                Console.WriteLine("Не известная команда");
                return;
        }
        Console.WriteLine("Результат: " + result);













                } }
    

