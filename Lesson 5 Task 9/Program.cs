namespace Lesson_5_task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SevenWonders first = new SevenWonders();
            SevenWonders second = new SevenWonders();
            SevenWonders third = new SevenWonders();
            SevenWonders fourth = new SevenWonders();
            SevenWonders fifth = new SevenWonders();
            SevenWonders sixth = new SevenWonders();
            SevenWonders seventh = new SevenWonders();

            first.Name = "Great Pyramid of Giza";
            second.Name = "The lofty gardens of Babylon";
            third.Name = "Zeus statue in Olympia";
            fourth.Name = "Temple of Artemis at Ephesus";
            fifth.Name = "mausoleum in Halicarnassus";
            sixth.Name = "The Colossus of Rhodes";
            seventh.Name = "Alexandrian lighthouse";

            Console.WriteLine("Seven wonders of the world: ");
            Console.WriteLine($"1 - {first.Name}");
            Console.WriteLine($"2 - {second.Name}");
            Console.WriteLine($"3 - {third.Name}");
            Console.WriteLine($"4 - {fourth.Name}");
            Console.WriteLine($"5 - {fifth.Name}");
            Console.WriteLine($"6 - {sixth.Name}");
            Console.WriteLine($"7 - {seventh.Name}");
        }
    }
}