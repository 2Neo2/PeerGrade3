using System;

partial class Program
{
    static void HowToGenerating(int value )
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How you want generation matrix: ");
            Console.WriteLine();
            Console.WriteLine("Input <1> if you want generation with file or something else generation random numbers in matrix");
            Console.ResetColor();
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                DeterminateOperationFromFile(value);
                break;
            }
            else 
            {
                DeterminateOperation(value);
                break;
            }
        }
    }

    static void DeterminateOperation(int value)
    {
        Console.WriteLine(value);
        switch (value)
        {
            case 1 :
                TraceMatrix();
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 2:
                TransponsitionMatrix();
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 3 :
                SumOrDifferenceMatrix();
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 4:
                MultiplicationTwoMatrixs();
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 5:
                MultiplicationByNumber();
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 6:
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
        }
    }

    static void MultiplicationByNumber()
    {
        Console.Clear();
        int x, y;
        Random rand = new Random();
        x = rand.Next(2, 11); 
        y = rand.Next(2, 11);
        double [,] array1 = new double[x,y];
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array1[i, j] = rand.Next(-20, 20);
            }
        }
        PrintMatrix(array1,x,y);
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Matrix after multiplication: ");
        int count = rand.Next(-20, 20);
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array1[i, j] *= count;
            }
        }
        PrintMatrix(array1,x,y);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Number on which matrix is multiplication - {count}");
        Console.ResetColor();
    }

    static void MultiplicationTwoMatrixs()
    {
        Console.Clear();
        int x, y, w, z;
        Random rand = new Random();
        while (true)
        {
            x = rand.Next(2, 11); 
            y = rand.Next(2, 11);
            w = rand.Next(2, 11);
            z = rand.Next(2, 11);
            if (y==w )
            {
                break;
            }
        }
        double [,] array1 = new double[x,y];
        double [,] array2 = new double[w,z];
        Console.WriteLine();
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array1[i, j] = rand.Next(-20, 21);
            }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("First Matrix:");
        Console.ResetColor();
        PrintMatrix(array1,x,y);
        Console.WriteLine();
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j< z; j++)
            {
                array2[i, j] = rand.Next(-20, 21);
            }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Second Matrix:");
        Console.ResetColor();
        PrintMatrix(array2,w,z);
        Multiplication(array1,array2,x,z, y);
    }

    static void Multiplication(double[,] array1, double[,] array2, int x , int z, int y)
    {
        double [,] finalArray = new double[x,z];
        for (var i = 0; i < x; i++)
        {
            for (var j = 0; j < z; j++)
            {
                finalArray[i, j] = 0;

                for (var k = 0; k < y; k++)
                {
                    finalArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Multiplication: ");
        PrintMatrix(finalArray,x,z);
        Console.ResetColor();
    }

    static void SumOrDifferenceMatrix()
    {
        Console.Clear();
        int x, y, w, z;
        Random rand = new Random();
        while (true)
        {
             x = rand.Next(2, 11); 
             y = rand.Next(2, 11);
             w = rand.Next(2, 11);
             z = rand.Next(2, 11);
            if (x==w && y==z )
            {
                break;
            }
        }
        double [,] array1 = new double[x,y];
        double [,] array2 = new double[x,y];
        Console.WriteLine();
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array1[i, j] = rand.Next(-20, 21);
            }
        }
        Console.WriteLine("First Matrix:");
        PrintMatrix(array1,x,y);
        Console.WriteLine();
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array2[i, j] = rand.Next(-20, 21);
            }
        }
        Console.WriteLine("Second Matrix:");
        PrintMatrix(array2,x,y);
        SumOrDifference(array1,array2, x, y);
    }

    static void SumOrDifference(double [,] array1, double [,] array2, int x , int y)
    {
        Console.WriteLine("If you want sum matrix input < + > , input < - > if you want different matrix");
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "+")
            {
                Sum(array1,array2,x , y);
                break;
            }
            else if (input == "-")
            {
                Difference(array1,array2,x,y);
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }

    static void Sum(double[,] array1, double[,] array2, int x , int y )
    {
        Console.WriteLine("Final Matrix: ");
        double[,] finalArray = new double[x,y];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                finalArray[i, j] = array1[i, j] + array2[i, j];
                Console.Write($"{finalArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void Difference(double[,] array1, double[,] array2, int x, int y)
    {
        Console.WriteLine("Final Matrix: ");
        double[,] finalArray = new double[x,y];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                finalArray[i, j] = array1[i, j] - array2[i, j];
                Console.Write($"{finalArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void TransponsitionMatrix()
    {
        Console.Clear();
        Random rand = new Random();
        int x = rand.Next(2, 11);
        int y = rand.Next(2, 11);
        double [,] array = new double[x,y];
        double t;
        Console.WriteLine();
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array[i, j] = rand.Next(-20, 21);
            }
        }
        PrintMatrix(array,x,y);
        for(int i = 0; i < x; ++i)
        {
            for(int j = i; j < y; ++j)
            {
                t = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = t;
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Size generating from 2 to 10 and elements of matrix generating from -20 to 20");
        Console.WriteLine();
        Console.WriteLine("Transposition Matrix:");
        Console.WriteLine();
        Console.ResetColor();
        PrintMatrix(array, x ,y);
    }

    static void TraceMatrix()
    {
        Console.Clear();
        double count = 0;
        int x, y;
        Random rand = new Random();
        x = rand.Next(2, 11);
        y = rand.Next(2, 11);
        while (true)
        {
            if ( x!=y )
            {
                x = rand.Next(2, 11);
                y = rand.Next(2, 11);
            }
            else
            {
                break;
            }
        }
        double [,] array = new double[x,y];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array[i, j] = rand.Next(-20, 21);
                if (i == j)
                {
                    count += array[i, j];
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Size generating from 2 to 10 and elements of matrix generating from -20 to 20");
        Console.WriteLine();
        Console.WriteLine($"Trace Matrix with generation elements: {count}");
        Console.WriteLine();
        Console.ResetColor();
        PrintMatrix(array,x ,y);
    }

    static void PrintMatrix(double[,] array, int x , int y)
    {
        Console.WriteLine("Generation Matrix :");
        Console.WriteLine();
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}