using System;

namespace ChapterSeven
{
    class ChapterSeven
    {

        static void NumberTen()
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int maxCounter = 0, currentCounter = 1, maxElement = 0;
            Array.Sort(array);
            for(int x = 1; x < array.Length; x++)
            {
                if (array[x] == array[x-1])
                {
                    currentCounter++;
                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                        maxElement = array[x];
                    }

                }
               else
                {
                    currentCounter = 1;
                }
            }
            Console.WriteLine("{0} appeared the most with {1} occurances", maxElement, maxCounter);

        }

        static void NumberFourteen()
        {
            int maxCounter = 0, currentCounter = 1;
            string maxElement = "";

            string[,] stringMatrix =
            {
                    {"a", "b", "c", "d"},
                    {"b", "a", "d", "c"},
                    {"c", "d", "a", "b"},
            };



        }


        static void Main(string[] args)
        {
            NumberTen();
        }
    }
}
