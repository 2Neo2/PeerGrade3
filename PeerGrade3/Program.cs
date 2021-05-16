using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Transactions;

/// <summary>
/// проверить транспонирование во всех трех случаях и сделать определитель а также считывание из файла
/// </summary>
partial class Program
{
    static void Main(string[] args)
    {
        do
        {
            string input;
            Console.Clear();
            Menu();
            while (true)
            {
                Console.WriteLine("Operation -- ");
                input =Console.ReadLine();
                if (CorrectInput(input))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input, Neo -_-");
                }
            }
            Start(input);
            
            if (!RepeatSolution())
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Thank you!");
                Console.ResetColor();
                break;
            }
        } while (true);
    }

    static void Start(string input)
    {
        Console.Clear();
        int value = int.Parse(input);
        switch (value)
        {
            case 1:
                if (WhichMatrix())
                {
                    Console.Clear();
                    HowToGenerating(value);
                }
                else
                {
                    OperationUserInput1();
                }
                break;
            case 2:
                if (WhichMatrix())
                {
                    Console.Clear();
                    HowToGenerating(value);
                }
                else
                {
                    OperationUserInput2();
                }
                break;
            case 3:
                if (WhichMatrix())
                {
                    Console.Clear();
                    HowToGenerating(value);
                }
                else
                {
                    OperationUserInput3();
                }
                break;
            case 4:
                if (WhichMatrix())
                {
                    Console.Clear();
                    HowToGenerating(value);
                    
                }
                else
                {
                    OperationUserInput4();
                }
                break;
            case 5:
                if (WhichMatrix())
                {
                    Console.Clear();
                    HowToGenerating(value);
                    
                }
                else
                {
                    OperationUserInput5();
                }
                break;
            case 6:
                if (WhichMatrix())
                {
                    Console.Clear();
                    HowToGenerating(value);
                }
                else
                {
                    OperationUserInput6();
                }
                break;
        }
    }

    static void OperationUserInput6()
    {
        
    }

    static void OperationUserInput4()
    {
        int x, y, w, z;
        while (true)
        {
            Console.Clear();
            string input1;
            string input2;
            Console.WriteLine("Input size first Matrix :");
            while (true)
            {
                Console.Write("Variable 1 -- ");
                input1 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Variable 2 -- ");
                input2 = Console.ReadLine();
                if (CheckInput(input1 , input2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            Console.Clear();
            string input3;
            string input4;
            Console.WriteLine("Input size second Matrix :");
            while (true)
            {
                Console.Write("Variable 1 -- ");
                input3 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Variable 2 -- ");
                input4 = Console.ReadLine();
                if (CheckInput(input3 , input4))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            x = int.Parse(input1);
            y = int.Parse(input2); 
            z = int.Parse(input3);
            w = int.Parse(input4);
            if (y == z )
            {
                break;

            }
            else
            {
                Console.WriteLine(
                    "Multiplication is not possible! The number of columns of the first matrix is not equal to the " +
                    "number of rows of the second matrix");
            }
        }

        double[,] array1 = GetMatrix(x,y);
        double[,] array2 = GetMatrix(z, w);
        MultiplicationMatrix(array1, array2,x,w, y);
    }

    static void MultiplicationMatrix(double[,] array1, double[,] array2, int x , int w, int y)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Multiplication Matrix:");
        var finalArray = new double[x, w];

        for (var i = 0; i < x; i++)
        {
            for (var j = 0; j < w; j++)
            {
                finalArray[i, j] = 0;

                for (var k = 0; k < y; k++)
                {
                    finalArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }

        Console.WriteLine();
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < w; j++)
            {
                Console.Write($"{finalArray[i,j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.ResetColor();
        Console.WriteLine("Input enter");
        Console.ReadLine();
    }
    /// <summary>
    /// начало блока 5 операции
    /// </summary>
    static void OperationUserInput5()
    {
        Console.Clear();
        string input1;
        string input2;
        Console.WriteLine("Input size of Matrix :");
        while (true)
        {
            Console.Write("Variable 1 -- ");
            input1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Variable 2 -- ");
            input2 = Console.ReadLine();
            if (CheckInput(input1 , input2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        Console.Clear();
        int x = int.Parse(input1);
        int y = int.Parse(input2);
        double [,] array = GetMatrix(x, y);
        Output(array,x ,y );
        Console.WriteLine();
        Console.WriteLine("Input number on which you want product matrix :");
        double z;
        while (true)
        {
            ;
            string value = Console.ReadLine();
            if (double.TryParse(value, out z))
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        Output5(array, z,x,y);
    }

    static void Output5(double[,] array, double z, int x, int y )
    {
        Console.Clear();
        Console.WriteLine("Final Matrix");
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array[i, j] *=  z;
                Console.Write($"{array[i, j]} ");
            }

            Console.WriteLine();
        }
        Console.ResetColor();
    }
    /// конец блока 5 операции

    /// <summary>
    /// это начало блока 4 опреации
    /// </summary>
    static void OperationUserInput3()
    {
        while (true)
        {
            string input1;
            string input2;
            string input3;
            string input4;
            Console.WriteLine("Input size 1 of Matrix");
            while (true)
            {
                Console.Write("Variable 1 -- ");
                input1 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Variable 2 -- ");
                input2 = Console.ReadLine();
                if (CheckInput(input1 , input2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Input size 2 of Matrix");
            while (true)
            {
                Console.Write("Variable 1 -- ");
                input3 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Variable 2 -- ");
                input4 = Console.ReadLine();
                if (CheckInput(input1 , input2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }

            int x = int.Parse(input1);
            int y = int.Parse(input2);
            int z = int.Parse(input3);
            int w = int.Parse(input4);
            if (x == z && y == w)
            {
                MainPartOperation(x,y,z,w);
                break;
            }
            else
            {
                Console.WriteLine("Matrices should be equal size ");
            }
        }
    }

    static void MainPartOperation(int x, int y, int z, int w)
    {
        Console.Clear();
        double[,] array1 = GetMatrix(x, y);
        double[,] array2 = GetMatrix(z, w);
        SumOrDifferentMatrix(array1,array2,x,y);
    }

    static void SumOrDifferentMatrix(double[,] array1, double[,] array2, int x, int y)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("If you want sum matrix input < + > , input < - > if you want different matrix");
            double[,] finalArray = new double[x, y];
            string input = Console.ReadLine();
            if (input == "+")
            {
                Console.WriteLine("Its final array: ");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        finalArray[i, j] = array1[i, j] + array2[i, j];
                        Console.Write($"{finalArray[i, j]} ");
                    }

                    Console.WriteLine();
                }
                Console.ResetColor();
                break;
            }
            else if (input == "-")
            {
                Console.WriteLine("Its final array: ");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        finalArray[i, j] = array1[i, j] - array2[i, j];
                        Console.Write($"{finalArray[i, j]} ");
                    }

                    Console.WriteLine();
                }
                Console.ResetColor();
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
    /// это конец блока 4 операции
    

    /// <summary>
    /// Это начало блока 2 операции
    /// </summary>
    static void OperationUserInput2()
    {
        Console.Clear();
        string input1;
        string input2;
        Console.WriteLine("Input size of Matrix :");
        while (true)
        {
            Console.Write("Variable 1 -- ");
            input1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Variable 2 -- ");
            input2 = Console.ReadLine();
            if (CheckInput(input1 , input2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        Console.Clear();
        int x = int.Parse(input1);
        int y = int.Parse(input2);
        double[,] array = GetMatrix(x, y);
        Output(array,x ,y );
        double t;
        for(int i = 0; i < x; ++i)
        {
            for(int j = i; j < y; ++j)
            {
                t = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = t;
            }
        }
        Output(array,x,y);
    }

    static void Output(double[,] matrix,int x , int y )
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Your matrix:");
        Console.WriteLine();
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();
        Console.WriteLine();
    }
    /// <summary>
    /// это конце блока 2 операции
    /// </summary>

    /// <summary>
    /// это начало блока 1 операции
    /// </summary>
    static void OperationUserInput1()
    {
        Console.Clear();
        string input1;
        int z;
        string input2;
        int w;
        Console.WriteLine("Input size of Matrix :");
        while (true)
        {
            Console.Write("Variable 1 -- ");
            input1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Variable 2 -- ");
            input2 = Console.ReadLine();
            if (CheckInput(input1 , input2) && int.TryParse(input1, out z ) && int.TryParse(input2,out w) && z==w)
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        Console.Clear();
        int x = int.Parse(input1);
        int y = int.Parse(input2);
        double[,] array = GetMatrix(x, y);
        double count = 0;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (i == j)
                {
                    count += array[i, j];
                }
            }
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Trace if Matrix = {count}");
        Console.ResetColor();
        Console.WriteLine();
    }

    static double [,] GetMatrix(int x, int y)
    {
        Console.WriteLine("Input elements of Matrix:");
        double[,] matrix = new double[x,y];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    double h;
                    if (double.TryParse(input, out h))
                    {
                        matrix[i, j] = h;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input");
                    }
                }
            }
        }
        return matrix;
    }

    static bool CheckInput(string input1 , string input2)
    {
        int x, y;
        if (int.TryParse(input1, out x) && int.TryParse(input2, out y))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// Это конец блока 1 операции
    /// </summary>
    /// <returns></returns>
    static bool WhichMatrix()
    {
        Console.WriteLine("How you want fill of matrix? Push <1> if you want fill the matrix especially , Push any key, if"
            + " you want fill the matrix by yourself.");
        if (Console.ReadKey().Key == ConsoleKey.D1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\t\t\t\t===============================================");
        Console.WriteLine("\t\t\t\t\t\t\tWelcome! You are now in Matrix, Neo wait you...");
        Console.WriteLine("\t\t\t\t\t\t\t===============================================");
        Console.ResetColor();
        Console.WriteLine();
        Rules();
    }

    static void Rules()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Its all operations with matrix, you should choose one of them: ");
        Console.WriteLine();
        Console.WriteLine("\t\t\t1.Find the trace of a Matrix.");
        Console.WriteLine("\t\t\t2.Transposition of a Matrix.");
        Console.WriteLine("\t\t\t3.Sum of two Matrices or Difference of two Matrices. ");
        Console.WriteLine("\t\t\t4.Multiplication of two Matrices.");
        Console.WriteLine("\t\t\t5.Multiplication of a matrix by a number.");
        Console.WriteLine("\t\t\t6.Finding the determinant of the matrix.");
        Console.WriteLine("_______________________________________________________________________________________");
        Console.ResetColor();
    }

    static bool CorrectInput(string input)
    {
        int x;
        if (int.TryParse(input, out x) && x >= 1 && x <= 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool RepeatSolution()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("If you want continue push <1> , if you wand end push any key");
        Console.ResetColor();
        if (Console.ReadKey().Key == ConsoleKey.D1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}