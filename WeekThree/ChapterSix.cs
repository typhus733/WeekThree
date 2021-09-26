using System;

namespace WeekThree
{
    class ChapterSix
    {

        static void NumberFour()
        {
            string[] suits = {"Clubs", "Spades", "Diamonds", "Hearts"};
            string[] face = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            for (int suitCounter = 0;  suitCounter < 4; suitCounter++)
            {
                for (int faceCounter = 0; faceCounter < 14; faceCounter++)
                {
                        Console.WriteLine("{0} of {1}", face[faceCounter], suits[suitCounter]);
                }
            }
        }

        static void NumberTen()
        {
            Console.Write("Enter an integer: ");
            int inputNum = int.Parse(Console.ReadLine());

            for(int x = 1; x <= inputNum; x++)
            {
                for (int y = 0; y < inputNum; y++)
                {
                    Console.Write(x + y);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        static void NumberSixteen()
        {
            Console.Write("Enter an integer: ");
            int inputNum = int.Parse(Console.ReadLine());
            int[] array = new int[inputNum];
            int indexRandom;
            
            for (int x = 0; x < inputNum; x++)
            {
                array[x] = x + 1;
            }

            var random = new Random();
            
            for (int x = 0; x <= inputNum; x++)
            {
                indexRandom = random.Next(0, inputNum);
                if(array[indexRandom] != 0)
                {
                    Console.WriteLine(array[indexRandom]);
                    array[indexRandom] = 0;
                }
                else
                {
                    x--;
                }
            }
        }
        static void Main(string[] args)
        {
            NumberFour();
            NumberTen();
            NumberSixteen();
        }
    }
}
