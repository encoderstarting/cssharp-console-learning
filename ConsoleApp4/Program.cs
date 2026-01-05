Console.WriteLine("Введите возраст: ");
string input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int age);
