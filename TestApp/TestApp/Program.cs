using System;
using TestApp.Drawers.Main;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is drawing school. PLease set students count");
            string input = Console.ReadLine();
            int count;

            try
            {
                if (int.TryParse(input, out count))
                {
                    var artClass = new ArtClass(count);

                    artClass
                        .InviteDrawers()
                        .AbsenceСheck()
                        .StartLesson();
                }
                else
                {
                    Console.WriteLine("It was necessary to enter a number. We will set the quantity ourselves");
                    var artClass = new ArtClass();

                    artClass
                        .InviteDrawers()
                        .AbsenceСheck()
                        .StartLesson();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The lesson did not take place. There was an accident: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}
