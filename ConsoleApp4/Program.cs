
Console.WriteLine("Выберите что хотите запустить: ");
Console.WriteLine("1 - Проверка баллов");
Console.WriteLine("2 - Проверка возраста");
Console.WriteLine("3 - Калькулятор");
bool number = int.TryParse(Console.ReadLine(), out int num);
if (!number)
{
    Console.WriteLine("Ошибка! Повторите попытку!");
    return;
}
else if (num == 1)
{
    GradeCheck.Run();
}
else if (num  == 2)
{
    CheckAge.Run();
}
else if (num == 3)
{
    calculator.Run();
}