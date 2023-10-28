namespace MobileNumberProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your mobilenumber?");
            string mobilenumber = Console.ReadLine();
            string mobilnumber = mobilenumber.Trim();
            string newSub = mobilenumber.Substring(0 , 5);
            Console.WriteLine(newSub);
            

        }
    }
}