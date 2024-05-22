// See https://aka.ms/new-console-template for more information
using System;

public class UserData
{
    public string Name;
    public int level;
    public UserData(string name, int lv)
    {
        this.Name = name;
        this.level = lv;

    }
    static void Main(string[] arg)
    {
        List<UserData> abc = new List<UserData>();
        abc.Add(new UserData("lmht", 900));
        abc.Add(new UserData("genshin", 60));
        abc.Add(new UserData("ir", 99999));

        var Xuat = abc.Select( a => new { a.Name, a.level } );
        foreach( var s in Xuat)
        {
            Console.WriteLine( "Name: " + s.Name + " | level: " + s.level );
        }

        Console.WriteLine();

        var SapXep = abc.OrderByDescending( a => a.level );
        foreach( var x in SapXep)
        {
            Console.WriteLine("Name: " + x.Name + " | level: " + x.level);
        }
    }
   
} 

    

