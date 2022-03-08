using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ExceptionDemo
{
    //static void Main(string[] args)
    //{
    #region IOException
    //try
    //{
    //    File.Open(@"D:\demo.txt",FileMode.Open);
    //}
    //catch(FileNotFoundException)
    //{
    //    Console.WriteLine("Not Found");
    //}
    //catch(IOException)
    //{
    //    Console.WriteLine("IO");
    //}
    #endregion
    #region DividebyZero
    //int a = 10;
    //int b = 0;
    //int c = 0;

    //try
    //{
    //    c = a / b;
    //    Console.WriteLine(c);
    //}
    //catch (DivideByZeroException e)
    //{
    //    Console.WriteLine(e.Message);
    //}
    #endregion
    #region NullReference
    //var divider = 0;

    //try
    //{
    //    try
    //    {
    //        var result = 100 / divider;
    //    }
    //    catch (NullReferenceException ex)
    //    {
    //        Console.WriteLine("Inner catch");
    //    }
    //}
    //catch
    //{
    //    Console.WriteLine("Outer catch");
    //}
    #endregion
    #region IndexOutOfRange
    //try
    //{
    //    int[] n = new int[5] { 66, 33, 56, 23, 81 };
    //    int i, j;
    //    // error: IndexOutOfRangeException
    //    for (j = 0; j < 10; j++)
    //    {
    //        Console.WriteLine("Element[{0}] = {1}", j, n[j]);
    //    }
    //    Console.ReadKey();
    //}
    //catch (System.IndexOutOfRangeException e)
    //{
    //    Console.WriteLine(e);
    //}
    #endregion
    #region OutOfMemory
    //StringBuilder sb = new StringBuilder(15, 15);
    //sb.Append("Substring #1 ");
    //try
    //{

    //    var print = sb.Insert(0, "Substring #2 ", 1);
    //    //Console.WriteLine(print);

    //}
    //catch (OutOfMemoryException e)
    //{
    //    Console.WriteLine("Out of Memory: {0}", e.Message);
    //}
    #endregion
    #region Exception
    //try
    //{
    //    string str = "abc";
    //    int I1= int.Parse(str);

    //}
    //catch(Exception)
    //{
    //    Console.WriteLine("Exception");
    //}
    #endregion
    #region Multiple catch
    //int a, b, c;
    //Console.WriteLine("ENTER ANY TWO NUBERS");
    //try
    //{
    //    a = int.Parse(Console.ReadLine());
    //    b = int.Parse(Console.ReadLine());
    //    c = a / b;
    //    Console.WriteLine("C VALUE = " + c);
    //}
    //catch (DivideByZeroException dbze)
    //{
    //    Console.WriteLine("second number should not be zero");
    //}
    //catch (FormatException fe)
    //{
    //    Console.WriteLine("enter only integer numbers");
    //}
    //Console.ReadKey();
    #endregion
    #region Age>18 Exception
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
            : base(message)
        {

        }
    }
    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate(19);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e); }
            Console.WriteLine("Rest of the code");
        }
    }
    #endregion
}



