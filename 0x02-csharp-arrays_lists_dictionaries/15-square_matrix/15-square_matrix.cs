using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        for (int a = 0; a < myMatrix.GetLength(0); a++)
        {
            for (int b = 0; b < myMatrix.GetLength(1); b++)
                myMatrix[a,b] = myMatrix[a,b] * myMatrix[a,b];
        }
        
        return(myMatrix);
    }
}
