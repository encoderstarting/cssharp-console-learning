
Console.WriteLine("Выберите что хотите запустить: ");
Console.WriteLine("1 - Проверка баллов");
Console.WriteLine("2 - Проверка возраста");
Console.WriteLine("3 - Калькулятор");
string num  = Console.ReadLine();
if (num == "1")
{
    GradeCheck.Run();
}
else if (num  == "2")
{
    CheckAge.Run();
}
else if (num == "3")
{
    calculator.Run();
}