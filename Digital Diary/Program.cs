using System;

class Program
{
    static void Main()
    {
        Diary diary = new Diary();
        while (true)
        {
            Console.WriteLine("\nDigital Diary");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. View All Entries");
            Console.WriteLine("3. Search Entry by Date (YYYY-MM-DD)");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    Console.Write("Write your diary entry: ");
                    string text = Console.ReadLine();
                    diary.WriteEntry(text);
                    break;
                case "2":
                    diary.ViewAllEntries();
                    break;
                case "3":
                    Console.Write("Enter date (YYYY-MM-DD): ");
                    string date = Console.ReadLine();
                    diary.SearchByDate(date);
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}