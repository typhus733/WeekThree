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
            
            string maxElement = "";
            string[,] stringMatrix =
            {
                    {"b", "a", "d", "a"},
                    {"c", "b", "a", "d"},
                    {"c", "d", "a", "d"},
            };
            int maxCounter = 0, currentCounter = 0, rowLen = stringMatrix.GetLength(0), colLen = stringMatrix.GetLength(1);
            for (int row = 0; row < rowLen - 1; row++)
            {
                for (int col = 0; col < colLen - 1; col++)
                {
                    if (stringMatrix[row, col] == stringMatrix[row + 1, col])
                    { 
                        for (int x = row; x < rowLen - 1; x++)
                        {
                            if (stringMatrix[x, col] == stringMatrix[row, col])
                            {
                                currentCounter++;
                                if (currentCounter > maxCounter)
                                {
                                    maxCounter = currentCounter;
                                    maxElement = stringMatrix[row, col];
                                }
                            }
                        }
                    }

                    currentCounter = 1;

                    if (stringMatrix[row, col] == stringMatrix[row, col + 1])
                    {
                        for (int x = col; x < colLen - 1; x++)
                        {
                            if (stringMatrix[row, x] == stringMatrix[row, col])
                            {
                                currentCounter++;
                                if (currentCounter > maxCounter)
                                {
                                    maxCounter = currentCounter;
                                    maxElement = stringMatrix[row, col];
                                }
                            }
                        }
                    }

                    currentCounter = 1;

                    if (stringMatrix[row, col] == stringMatrix[row + 1, col + 1])
                    {
                        for (int x = row; x < rowLen - 1; x++)
                        {
                            if (stringMatrix[x + 1, x + 1] == stringMatrix[row, col])
                            {
                                currentCounter++;
                                if (currentCounter > maxCounter)
                                {
                                    maxCounter = currentCounter;
                                    maxElement = stringMatrix[row, col];
                                }
                            }
                        }
                    }

                    currentCounter = 1;

                }

            }

            Console.WriteLine("{0} with {1} occurences", maxElement, maxCounter);
        }
        static void Main(string[] args)
        {
            //NumberTen();
            NumberFourteen();
        }
    }
}
