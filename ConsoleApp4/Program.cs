Console.WriteLine("Введите возраст: ");
string input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int age);
if (!int.TryParse(input, out age))
{
    Console.WriteLine("Вы ввели не число!");
}
else if (age < 0)
{
    Console.WriteLine("Возраст не может быть отрицательным!");
}
else if (age < 18)
{
    Console.WriteLine("Не совершенно летний пользователь!");
}
else if (age <= 64)
{
    Console.WriteLine("Доступ разрешен!");
}
else if (age > 64)
{
    Console.WriteLine("Пенсионный возраст!");
}
    
