public static class GradeCheck
{
    public static void Run()
    {
        Console.WriteLine("Введите оценку от 0 до 100: ");
        string input = Console.ReadLine();
        bool isNumber = int.TryParse(input, out int score);
        if (!isNumber)
        {
            Console.WriteLine("Вы ввели не цифру!");
        }
        if (score < 0 || score > 100) 
            Console.WriteLine("Неккоретная оценка!");
        else if (score > 90)
        {
            Console.WriteLine("Otlichno");
        }
        else if (score > 75)
        {
            Console.WriteLine("horosho");
        }
        else if (score > 60)
        {
            Console.WriteLine("Ydovotvoritlno");
        }
        else
        {
            Console.WriteLine("HUYNA");
        }

    }
}
