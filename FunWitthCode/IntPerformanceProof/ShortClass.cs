using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWitthCode.IntPerformanceProof
{
    public class ShortClass
    {

        public short Height { get; set; }
        public short Width { get; set; }
        public short Length { get; set; }
        public short[,,] Cubes { get; private set; }
        private short upperBound = 16380;

        public ShortClass(short length, short width, short height)
        {
            Length = length;
            Width = width;
            Height = height;
        }


        public void PopulateCubeWithSmallUnitsCubes()
        {
            Random random = new Random();
            Cubes = new short[Length, Width, Height];
            for (short i = 0; i < Length; i++)
            {
                for (short j = 0; j < Width; j++)
                {
                    for (short k = 0; k < Height; k++)
                    {
                        Cubes[i, j, k] = (short)(i + j + k);
                    }
                }
            }
        }



    }
}
