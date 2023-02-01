using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_MaríaRodriguez
{
    internal class DataClass
    {
        public static int[,] matrixPrice;
        public static void initMatrix()
        {
            matrixPrice = new int[,] {

            {8,6,6 },
            {22,14,12},
            {10,5,5},
            {35,30,20},
            {45,40,0}

            };
        }
    }
}
