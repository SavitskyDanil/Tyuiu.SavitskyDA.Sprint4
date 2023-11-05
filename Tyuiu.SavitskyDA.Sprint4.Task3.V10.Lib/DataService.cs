using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SavitskyDA.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task4V10
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int count  = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if  ((i == 2) && matrix[i, j] > count)
                    {
                        count = matrix[i, j];
                    }
                }
            }
            return count;
        }
    }
}
