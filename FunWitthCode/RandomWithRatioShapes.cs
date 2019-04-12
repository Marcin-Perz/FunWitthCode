using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWitthCode
{
    struct Size
    {
       public int Length { get; }

        public int Width { get; }
        public Size(int length, int width)
        {
            Length = length;
            Width = width;
        }
    }
    public class RandomWithRatioShapes
    {
        
        public char[,] Randomize()
        {
            Random random1 = new Random();
            int id = 1;
            char[,] resultArray = new char[100, 100];
            Size horizontal = new Size(28,7);
            Size vertical = new Size(7,28);



            for (int i = 0; i < resultArray.GetUpperBound(0); i++)
            {
                for (int k = 0; k < resultArray.GetUpperBound(1); k++)
                {
                    int rand = random1.Next(2);
                    if (rand == 1)
                    {
                        CheckIfFreeOrSame(resultArray[i, k + 1]);
                        if ((resultArray.GetUpperBound(0) - i) >= horizontal.Width)
                        {
                            for (int n = 0; n < horizontal.Width; n++)
                            {
                                resultArray[i + n, k] = getCharPRopepepr(id);

                            }
                        };
                    }
                    else
                    {
                        if (resultArray.GetUpperBound(1)-k>= vertical.Length)
                        {
                            bool checkIfFree = true ;
                            for (int n = 0; n < vertical.Length; n++)
                            {
                         
                                checkIfFree = CheckIfFreeOrSame(resultArray[i, k + n]) == true ? checkIfFree : false;
                            }
                            if (checkIfFree)
                            {
                                for (int n = 0; n < vertical.Length; n++)
                                {
                                    resultArray[i, k + n] = getCharPRopepepr(id);
                                }
                            }
                        }
                    }


                }

                id++;
            }

                return resultArray;
        }

        private static char getCharPRopepepr(int id)
        {
            char result = new char();
            switch (id % 24)
            {
                case 1:
                    result = 'a';
                    break;
                case 2:
                    result = 'b';
                    break;
                case 3:
                    result = 'c';
                    break;
                case 4:
                    result = 'd';
                    break;
                case 5:
                    result = 'e';
                    break;
                case 6:
                    result = 'f';
                    break;
                case 7:
                    result = 'g';
                    break;
                case 8:
                    result = 'h';
                    break;
            }

            return result;
        }

        private static bool CheckIfFreeOrSame(int toCheck, int qualifaier = 0)
        {
            if (toCheck == qualifaier && toCheck == 0) return true;
            return false;
        }
    }
}
