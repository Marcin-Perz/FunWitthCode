using System;

namespace FunWitthCode.IntPerformanceProof
{
    public class IntClass
    {

        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int[,,] Cubes { get; private set; }
        private int  upperBound = 16380;

        public IntClass(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }


        public void PopulateCubeWithSmallUnitsCubes()
        {
            Random random = new Random();
            Cubes = new int[Length, Width, Height];
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    for (int k = 0; k < Height; k++)
                    {
                        Cubes[i, j, k] = i + j + k;
                    }
                }
            }
        }



    }
}
