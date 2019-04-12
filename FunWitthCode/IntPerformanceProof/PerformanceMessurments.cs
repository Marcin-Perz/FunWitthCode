using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWitthCode.IntPerformanceProof
{
    public class PerformanceMessurmentBasicTypes
    {
        private short calculationsShort;
        private int calculationsInt;
        private long calculationsLong;
        private short timesExceededShort;
        private int timesExceededInt;
        private long timesExceededLong;


        private void calculationsShortIncrement()
        {
            if (calculationsShort == short.MaxValue)
            {
                timesExceededShort++; ;
                calculationsShort = default;
            }
            else
            {
                calculationsShort++;
            }
        }
        private void calculationsIntIncrement()
        {
            if (calculationsInt == int.MaxValue)
            {
                timesExceededInt++; ;
                calculationsInt = default;
            }
            else
            {
                calculationsInt++;
            }
        }

        private void calculationsLongIncrement()
        {
            if (calculationsLong == int.MaxValue)
            {
                timesExceededLong++; ;
                calculationsLong = default;
            }
            else
            {
                calculationsLong++;
            }
        }

        public string PopulateCubeWithTypeOfaClassConstructions( int dimension)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            int[,,] Cube = new int[dimension, dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    for (int k = 0; k < dimension; k++)
                    {
                        Cube[i, j, k] = i+j+k;
                        calculationsIntIncrement();
                    }
                }
            }
            stopwatch.Stop();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("It was {0}{1} calculations done in {2} ms.", timesExceededInt == 0 ? "" : string.Format("{0} times {1}", timesExceededInt, int.MaxValue) + " plus ", calculationsInt, stopwatch.Elapsed.TotalMilliseconds));
            return stringBuilder.ToString();
        }
        public string PopulateCubeWithTypeOfaClassConstructions(long dimension)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            long[,,] Cube = new long[dimension, dimension, dimension];
            for (long i = 0; i < dimension; i++)
            {
                for (long j = 0; j < dimension; j++)
                {
                    for (long k = 0; k < dimension; k++)
                    {
                        Cube[i, j, k] = i + j + k;
                        calculationsLongIncrement();
                    }
                }
            }
            stopwatch.Stop();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("It was {0}{1} calculations done in {2} ms.", timesExceededLong == 0 ? "" : string.Format("{0} times {1}", timesExceededLong, long.MaxValue) + " plus ", calculationsLong, stopwatch.Elapsed.TotalMilliseconds));
            return stringBuilder.ToString();
        }
        public string PopulateCubeWithTypeOfaClassConstructions(short dimension)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            short [,,] Cube = new short [dimension, dimension, dimension];
            for (short i = 0; i < dimension; i++)
            {
                for (short j = 0; j < dimension; j++)
                {
                    for (short k = 0; k < dimension; k++)
                    {
                        Cube[i, j, k] = (short)(i + j + k);
                        calculationsShortIncrement();
                    }
                }
            }
            stopwatch.Stop();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("It was {0}{1} calculations done in {2} ms.", timesExceededShort == 0 ? "" : string.Format("{0} times {1}", timesExceededShort, short.MaxValue) + " plus ", calculationsShort, stopwatch.Elapsed.TotalMilliseconds));
            return stringBuilder.ToString();
        }
    }


    public class PerformanceMessurments<T> where T : new()
    {
        private short calculationsShort;
        private int calculationsInt;
        private long calculationsLong;
        private short timesExceededShort;
        private int timesExceededInt;
        private long timesExceededLong;


        private void calculationsShortIncrement()
        {
            if (calculationsShort == short.MaxValue)
            {
                timesExceededShort++; ;
                calculationsShort = default;
            }
            else
            {
                calculationsShort++;
            }
        }
        private void calculationsIntIncrement()
        {
            if (calculationsInt == int.MaxValue)
            {
                timesExceededInt++; ;
                calculationsInt = default;
            }
            else
            {
                calculationsInt++;
            }
        }

        private void calculationsLongIncrement()
        {
            if (calculationsLong == int.MaxValue)
            {
                timesExceededLong++; ;
                calculationsLong = default;
            }
            else
            {
                calculationsLong++;
            }
        }

        public string PopulateCubeWithTypeOfaClassConstructions(int dimension)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            T[,,] Cube = new T[dimension, dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    for (int k = 0; k < dimension; k++)
                    {
                        Cube[i, j, k] = new T();
                        calculationsLongIncrement();
                    }
                }
            }
            stopwatch.Stop();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("It was {0}{1} calculations done in {1} ms.", timesExceededInt == 0 ? "" :string.Format("{0} times {1}",timesExceededInt, int.MaxValue) + " plus ", calculationsInt, stopwatch.Elapsed.TotalMilliseconds));
            return stringBuilder.ToString();
        }
        public string PopulateCubeWithTypeOfaClassConstructions(long dimension)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            T[,,] Cube = new T[dimension, dimension, dimension];
            for (long i = 0; i < dimension; i++)
            {
                for (long j = 0; j < dimension; j++)
                {
                    for (long k = 0; k < dimension; k++)
                    {
                        Cube[i, j, k] = new T();
                        calculationsIntIncrement();
                    }
                }
            }
            stopwatch.Stop();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("It was {0}{1} calculations done in {1} ms.", timesExceededLong == 0 ? "" : string.Format("{0} times {1}", timesExceededLong, long.MaxValue) + " plus ", calculationsLong, stopwatch.Elapsed.TotalMilliseconds));
            return stringBuilder.ToString();
        }
        public string PopulateCubeWithTypeOfaClassConstructions(short dimension)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            T[,,] Cube = new T[dimension, dimension, dimension];
            for (short i = 0; i < dimension; i++)
            {
                for (short j = 0; j < dimension; j++)
                {
                    for (short k = 0; k < dimension; k++)
                    {
                        Cube[i, j, k] = new T();
                        calculationsShortIncrement();
                    }
                }
            }
            stopwatch.Stop();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("It was {0}{1} calculations done in {1} ms.", timesExceededShort == 0 ? "" : string.Format("{0} times {1}", timesExceededShort, short.MaxValue) + " plus ", calculationsShort, stopwatch.Elapsed.TotalMilliseconds));
            return stringBuilder.ToString();
        }

    }
}
