namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {

                case "Math":
                    Console.WriteLine("Math is hard");
                    break;
                case "Science":
                    Console.WriteLine("Science is fun");
                    break;
                case "English":
                    Console.WriteLine("English is the best");
                    break;
                case "Social Studies":
                    Console.WriteLine("Social Studies is amazing");
                    break;
                default:
                    Console.WriteLine($"I never heard of {subject}");
                    break;
            }




        }
    }    }    