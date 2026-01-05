using System;
Console.WriteLine("Введите возраст: ");
string input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int age);
if (!isNumber)
{
    Console.WriteLine("Вы ввели не число!");
}
else if (age < 0)
{
    Console.WriteLine("Возраст не может быть отрицательным!");
}
else if (age < 18)
{
    Console.WriteLine("Несовершенно летний пользователь!");
}
else if (age <= 64)
{
    Console.WriteLine("Доступ разрешен!");
}
else
{
    Console.WriteLine("Пенсионный возраст!");
}
