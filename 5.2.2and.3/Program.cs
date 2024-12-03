namespace _5._2._2and._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = Convert.ToInt32(Console.ReadLine());//input the first number
            RecursiveNumbers(numbers);//Call the method
            int numbers1 = Convert.ToInt32(Console.ReadLine());//input the second number
            NewRecursiveNumbers(numbers1); //Call the method 
        }
        static void RecursiveNumbers(int natNums)
        {
            if (natNums > 0)//if the natural number is greater than 0
            {
                RecursiveNumbers(natNums - 1);//Recursion method 
                Console.WriteLine(natNums);//Putting the console writeLine below the recursion method makes it count up from 1 till it gets to the number
			}
        }

        static void NewRecursiveNumbers (int natNums1)//if the natural number is greater than 0
		{
            if ( natNums1 > 0)//if the natural number is greater than 0
			{
                Console.WriteLine(natNums1);//Putting the console writeLine above the recursion method makes it count down till it gets to 1
                NewRecursiveNumbers(natNums1 - 1);//Recursion method
            }
        }

    }
}
