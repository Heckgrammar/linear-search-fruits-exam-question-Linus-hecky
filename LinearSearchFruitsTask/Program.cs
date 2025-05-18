namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found

            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names

            Console.WriteLine("what word would you like to find");
            string answer = Console.ReadLine();
            bool isfound = false;

            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == answer)
                {
                    isfound = true;
                }
            }
            if (isfound == true)
            {
                Console.WriteLine("true");

            }
            else 
            {
                Console.WriteLine("false");
            }
        }
    }
}
