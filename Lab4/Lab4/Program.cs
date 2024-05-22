// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
        var newList = list.FindAll(item => item % 2 == 0);
        list.ForEach( value => { if (value % 2 == 0) { Console.WriteLine(value); } });
        Console.WriteLine();
        foreach (int item in newList)
        {   
            Console.WriteLine(item);
        }
    }
}
