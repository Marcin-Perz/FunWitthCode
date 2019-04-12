using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWitthCode.IntPerformanceProof
{
    public class LongClass : IValueClass
    {
        public long Height { get; set; }
        public long Width { get; set; }
        public long Length { get; set; }
        public long[,,] Cubes { get; private set; }
        private long upperBound = 16380;

        public LongClass(long length, long width, long height)
        {
            Length = length;
            Width = width;
            Height = height;
        }


        public void PopulateCubeWithTypeOfaClassConstructions()
        {
            Random random = new Random();
            Cubes = new long[Length, Width, Height];
            for (long i = 0; i < Length; i++)
            {
                for (long j = 0; j < Width; j++)
                {
                    for (long k = 0; k < Height; k++)
                    {
                        Cubes[i, j, k] = i + j + k;
                    }
                }
            }
        }
    }
}
