using System;
using System.IO;
using System.Runtime.InteropServices;

partial class Program
{
    static void DeterminateOperationFromFile(int value)
    {
        Console.WriteLine(value);
        switch (value)
        {
            case 1:
                InputOutFileTrace();
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 2:
                InputOutFileTransposition();
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 3:

                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 4:
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 5:
                InputOutFileMultiplicationByNumber();
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
            case 6:
                InputOutFileDeterminate();
                Console.WriteLine();
                Console.WriteLine("Input something and push enter :");
                Console.ReadLine();
                break;
        }
    }

    static void InputOutFileTrace()
    {
        double[,] array = GiveMatrixOutFile();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Your matrix: ");
        Console.ResetColor();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }

        double count=0 ;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == j)
                {
                    count += array[i, j];
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Trace that matrix : {count}");
        
    }

    static double[,] GiveMatrixOutFile()
    {
        double[,] matrix;
        while (true)
        {
            bool value = true;
            string path = ChooseDirectiory();

            string[] additionFromJug= File.ReadAllLines(path);

            string[][] jugArray= new string[additionFromJug.Length][];

            int len = 0;
        
            for (int i = 0; i < additionFromJug.Length; i++)
            {
                jugArray[i] = additionFromJug[i].Split(' ');
                len = jugArray[0].Length;
                if (len != jugArray[i].Length)
                {
                    value = false;
                }
            }

            for (int i = 0; i < jugArray.Length; i++)
            {
                for (int j = 0; j < jugArray[i].Length; j++)
                {
                    if (!double.TryParse(jugArray[i][j], out double temp))
                    {
                        value = false;
                    }
                }
            }
            
            if (value != false)
            {
                matrix = new double[jugArray.Length, jugArray[0].Length];
        
                for (int i = 0; i < jugArray.Length; i++)
                {
                    for (int j = 0; j < jugArray[i].Length; j++)
                    {
                        matrix[i, j] = double.Parse(jugArray[i][j]);
                    }
                }
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("File is not correct format or columns in matrix dont equal rows in matrix, change it ");
                Console.ResetColor();
            }
        }
        return matrix;
    }

    static string ChooseDirectiory()
    {
        string input = "";
        try
        {
            Console.WriteLine("Input path from file :");
            while (true)
            {
                input = Console.ReadLine();
                if (File.Exists(input))
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Incorrect path");
                    Console.ResetColor();
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Something doing not correctly");
        }
        return input;
    }

    static void InputOutFileTransposition()
    {
        try
        {
            Console.Clear();
            double[,] array =GiveMatrixOutFileByNumber ();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your matrix: ");
            Console.ResetColor();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Matrix after transposing ");
            double t;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    t = array[i,j];
                    array[i,j] = array[j,i];
                    array[j,i] = t;
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        catch (Exception )
        {
            Console.WriteLine("Something doing not correctly ");
            throw;
        }
    }

    static void InputOutFileMultiplicationByNumber()
    {
        Console.Clear();
        int x;
        double[,] array = GiveMatrixOutFileByNumber();
        Console.WriteLine("Input number on which you want multiplication matrix that : ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out x))
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Incorrect input");
                Console.ResetColor();
            }
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Your matrix: ");
        Console.ResetColor();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Matrix after multiplication: ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] *= x;
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    
    static double[,] GiveMatrixOutFileByNumber()
    {
        double[,] matrix;
        while (true)
        {
            bool value = true;
            string path = ChooseDirectiory();

            string[] additionFromJug= File.ReadAllLines(path);

            string[][] jugArray= new string[additionFromJug.Length][];

            int len = 0;
        
            for (int i = 0; i < additionFromJug.Length; i++)
            {
                jugArray[i] = additionFromJug[i].Split(' ');
                len = jugArray[0].Length;
            }

            for (int i = 0; i < jugArray.Length; i++)
            {
                for (int j = 0; j < jugArray[i].Length; j++)
                {
                    if (!double.TryParse(jugArray[i][j], out double temp))
                    {
                        value = false;
                    }
                }
            }
            
            if (value != false)
            {
                matrix = new double[jugArray.Length, jugArray[0].Length];
        
                for (int i = 0; i < jugArray.Length; i++)
                {
                    for (int j = 0; j < jugArray[i].Length; j++)
                    {
                        matrix[i, j] = double.Parse(jugArray[i][j]);
                    }
                }
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("File is not correct format or columns in matrix dont equal rows in matrix, change it ");
                Console.ResetColor();
            }
        }
        return matrix;
    }
    

    static void InputOutFileDeterminate()
    {
        Console.Clear();
        double[,] array = GiveMatrixOutFile();
    }
}
