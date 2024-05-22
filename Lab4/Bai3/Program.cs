// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

public class Student
{
    public string id;
    public string name;
    public int age;
    public Student(string id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    static void Main(string[] args)
    {

        List<Student> students = new List<Student>();
        students.Add(new Student("1", "manh", 21));
        students.Add(new Student("2", "thu", 19));
        students.Add(new Student("3", "duc", 18));
        students.Add(new Student("4", "quynh", 20));
        students.Add(new Student("5", "tuan", 22));

        var AgeList = from a in students
                      where a.age > 12 && a.age < 20
                      select a;

        foreach(var a in AgeList)
        {
            Console.WriteLine("Id: " + a.id + ", Name: " + a.name + ", Age: " + a.age);
        }

        Console.WriteLine();

        var AgeList2 = students.FindAll(a => a.age > 12 && a.age < 20);
        foreach(var a in AgeList2)
        {
            Console.WriteLine("Id: " + a.id + ", Name: " + a.name + ", Age: " + a.age);
        }
    }
}
