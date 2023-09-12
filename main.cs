using System;

public class Person
{
    public string name;
    public int age;

    public Person(String name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
public class Teacher : Person
{
    public string graduation;
    public int salary;

    public Teacher(string graduation, int salary)
    {
        this.graduation = graduation;
        this.salary = salary;
    }
}
public class Student : Person
{
    public double grade01;
    public double grade02;
    public double averageGrade;
    public Student(double grade01, double grade02)
    {
        this.grade01 = grade01;
        this.grade02 = grade02;
        this.averageGrade = (grade01 + grade02) / 2;
    }
}
public partial class Program
{
    public static void Main(string[] args)
    {  
        Person p = new Person();
        Teacher t = new Teacher();
        Student s = new Student();

        System.Console.WriteLine("Input 1 for Teacher or 2 for Student: ");
        System.Console.ReadLine();

        switch (register)
        {
            case 1:
            System.Console.WriteLine("Enter your name: ");
            p.name = System.Console.ReadLine();

            System.Console.WriteLine("Enter your age: ");
            int p.age = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter your graduation: ");
            t.graduation = System.Console.ReadLine();

            System.Console.WriteLine("Enter your salary: ");
            int t.salary = Convert.ToInt32(System.Console.ReadLine());
            break;

            case 2:
            System.Console.WriteLine("Enter your name: ");
            s.name = System.Console.ReadLine();

            System.Console.WriteLine("Enter your age: ");
            int s.age = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter your Grade 01: ");
            int s.grade01 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter your Grade 02: ");
            int s.grade02 = Convert.ToInt32(System.Console.ReadLine());
            break;

            default:
            Console.ReadLine("none");
        }
    }
}