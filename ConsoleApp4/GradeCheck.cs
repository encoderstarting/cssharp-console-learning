public static class GradeCheck
{
    public static void Run()
    {
        Console.WriteLine("Введите оценку от 0 до 100: ");
        string input = Console.ReadLine();
        bool isNumber = int.TryParse(input, out int score);

    }
}
