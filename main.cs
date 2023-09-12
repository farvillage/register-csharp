using System;

public class Person
{
    protected string name { get; private set; }
    protected int age { get; private set; }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

}
public class Teacher : Person
{
    protected string graduation { get; private set; }
    protected int salary { get; private set; }
    public Teacher(string name, int age, string graduation, int salary) : base(name, age)
    {
        this.graduation = graduation;
        this.salary = salary;
    }
}
public class Student : Person
{
    protected double grade01 { get; private set; }
    protected double grade02 { get; private set; }

    public Student(string name, int age, double grade01, double grade02) : base(name, age)
    {
        this.grade01 = grade01;
        this.grade02 = grade02;
    }
    public double averageGrade(double grade01, double grade02)
    {
        return (grade01 + grade02) / 2;
    }
}
public partial class Program
{
    public static void Main(string[] args)
    {  
        System.Console.WriteLine("Input 1 for Teacher or 2 for Student: ");
        int register = Convert.ToInt32(System.Console.ReadLine());

        switch (register)
        {
            case 1:
            System.Console.WriteLine("Enter your name: ");
            string name = System.Console.ReadLine();

            System.Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter your graduation: ");
            string graduation = System.Console.ReadLine();

            System.Console.WriteLine("Enter your salary: ");
            int salary = Convert.ToInt32(System.Console.ReadLine());

            Teacher t = new Teacher(name, age, graduation, salary);
            break;

            case 2:
            System.Console.WriteLine("Enter your name: ");
            name = System.Console.ReadLine();

            System.Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter your Grade 01: ");
            double grade01 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter your Grade 02: ");
            double grade02 = Convert.ToInt32(System.Console.ReadLine());

            Student s = new Student(name, age, grade01, grade02);
            System.Console.WriteLine("Your average grade is: " + s.averageGrade(grade01, grade02));
            break;

            default:
            Console.WriteLine("none");
            break;
        }
    }
}