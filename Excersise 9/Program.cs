namespace Excersise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a row width: ");
            int width = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many number of rows?");
            int rows = Int32.Parse(Console.ReadLine());

            //print rows going down 
            Console.WriteLine(); 
            for (int i =1; i <= rows; i++)
            {
                //inner for loop printing the width 
                for (int j = 1; j <= width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Problem 2 
            Console.WriteLine("Enter the Max number of asterisk in a row: ");
            int maxAster = Int32.Parse(Console.ReadLine());

            //print the asterisk 
            Console.WriteLine();
            for (int i = 1; i <= maxAster; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
               
        }

    } 
}