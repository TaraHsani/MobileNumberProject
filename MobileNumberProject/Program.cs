using System.Runtime;

namespace MobileNumberProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your mobilenumber?");
            string mobilenumber = Console.ReadLine();

            if (string.IsNullOrEmpty(mobilenumber))
            {
                Console.WriteLine("Please enter your mobilnumber!");

                return;

            }
            string mobilnumber = mobilenumber.Trim();
            string newSub = mobilenumber.Substring(0, 5);
            Console.WriteLine(newSub);
            string gender = Console.ReadLine(); //F or M
            string username = Console.ReadLine();
            int resualt = 0;


            if (newSub == "+98" || gender == "F" || username == "tara" || resualt == 0)
            {

                Console.WriteLine();

            }


        }
    }
}