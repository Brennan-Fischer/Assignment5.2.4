namespace Assignment5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input word to check if palindrome");
            string userInput= Console.ReadLine();
            checkPalindrome(userInput);



            static void checkPalindrome(string input)
            {
                if (input[0] != input[input.Length - 1])
                {
                    Console.WriteLine("Not a palindrome");
                    return;
                }
                if (input[0] == input[input.Length - 1]&& input.Length>2)
                {
                    input = input.Substring(1, input.Length-2);
                    checkPalindrome(input);
                    return;
                }
                if (input[0] == input[input.Length - 1] && input.Length <= 2)
                {
                    Console.WriteLine("String is a palindrome");
                }
                return;
            }
        }
    }
}
