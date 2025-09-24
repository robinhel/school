using System.Reflection.Metadata;
using Microsoft.VisualBasic;

namespace App;

class Course
{

    public string Courses;
    public string Professor;
    public string Points;

    public Course(string courses, string professor, string points)
    {
        Courses = courses;
        Professor = professor;
        Points = points;
    }

    public static void addcourse(List<Course> Courses,List<IUser> users)
    {
        {
            Console.WriteLine("what is the name of the course you want to create?");
            string courses = Console.ReadLine();
            Console.WriteLine("what professor is going to teach the course?");
            string professor = Console.ReadLine();
            Console.WriteLine("how much points do you earn?");
            string points = Console.ReadLine();

            Courses.Add(new Course(courses, professor, points));
        }
    }

    public static void ShowCourse(List<Course> courses)
    {
        Console.WriteLine("courses avalible are:");
        foreach (Course c in courses)
        {
            Console.WriteLine($"kurs: ({c.Courses}), lärare: ({c.Professor}), points: ({c.Points})");
        }
    }



}

/*        Console.WriteLine("____add a course___");
        Console.WriteLine("enter 'create' to make a course");
        string input = Console.ReadLine();
        if (input == "create");
        */