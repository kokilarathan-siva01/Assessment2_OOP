using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assessment_2_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is used to store the text file into an string variable array.
            String[] text_file_1a = File.ReadAllLines("GitRepositories_1a.txt");
            String[] text_file_1b = File.ReadAllLines("GitRepositories_1b.txt");
            String[] text_file_2a = File.ReadAllLines("GitRepositories_2a.txt");
            String[] text_file_2b = File.ReadAllLines("GitRepositories_2b.txt");
            String[] text_file_3a = File.ReadAllLines("GitRepositories_3a.txt");
            String[] text_file_3b = File.ReadAllLines("GitRepositories_3b.txt");
            // This method is used to check the difffernce between two text files and store the difference in a variable.
            IEnumerable<string> Check_Difference1 = text_file_1a.Except(text_file_1b);
            IEnumerable<string> Check_Difference2 = text_file_2a.Except(text_file_2b);
            IEnumerable<string> Check_Difference3 = text_file_3a.Except(text_file_3b);
            // Asking the using to choose what text file they want to compare.
            Console.WriteLine("Please Enter a number to select which files to check: -->" + "\n" +
                   "1 -> GitRepositories_1_a&b " + "\n" +
                   "2 -> GitRepositories_2_a&b" + "\n" +
                   "3 -> GitRepositories_3_a&b ");
            string user_Choice = Console.ReadLine();
            // A if statement to direct the application to display the correct text file option. 
            if (user_Choice == "1")
            {
                Console.WriteLine("Checking difference between GitRepositories_1a.txt and GitRepositories_1b.txt.");
                Checking_displaying(Check_Difference1);

            }
            else if(user_Choice == "2")
            {
                Console.WriteLine("Checking difference between GitRepositories_2a.txt and GitRepositories_2b.txt.");
                Checking_displaying(Check_Difference2);
            }
            else if (user_Choice == "3")
            {
                Console.WriteLine("Checking difference between GitRepositories_3a.txt and GitRepositories_3b.txt.");
                Checking_displaying(Check_Difference3);
            }
            else
            {
                Console.WriteLine("Sorry"+"Please select a valid number to proceeed.");
            }

            Console.ReadLine();

        }
        // This method is used to check if the String is empty or not, using the difference string.
        public static bool EmptyOrNot(object Check_Diff)
        {
            if (Check_Diff != null)
            {
                if (Check_Diff is IEnumerable<object>)
                {
                    return (Check_Diff as IEnumerable<object>).Any();
                }
            }
            return false;
        }
        //This method is used to check if the files are same or not, then display the output.
        public static void Checking_displaying(IEnumerable<String> file)
        {
            // An if statement to display the message according to the results.
            if (EmptyOrNot(file) == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Text file a and b are not different.", Console.ForegroundColor);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Text file a and b are different.", Console.ForegroundColor);
            }
        }



    }
}
