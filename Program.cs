namespace EvenAndOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint countOddNumber = 0;
            uint countEvenNumber = 0;

            Console.WriteLine("Input start range number: ");
            int startRange = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input last range number: ");
            int lastRange = Int32.Parse(Console.ReadLine());

            int sumOddNumber =0;
            int sumEvenNumber =0;

            while (startRange <= lastRange)
            {
                if (startRange % 2 == 0)
                {
                    sumEvenNumber += startRange;
                    countEvenNumber++;    
                }
                else
                {
                    sumOddNumber += startRange;
                    countOddNumber++;
                }

                startRange++;
            }
            
            Console.WriteLine($"Odd numbers = {countOddNumber}");
            Console.WriteLine($"Even numbers = {countEvenNumber}");
            Console.WriteLine($"Odd numbers sum = {sumOddNumber}");
            Console.WriteLine($"Even numbers sum = {sumEvenNumber}");


        }
    }
}
