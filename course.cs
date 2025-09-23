namespace App;

class Course
{

    public string Courses;
    public string Professor;
    public string Time;

    public Course(string courses, string professor, string time)
    {
        Courses = courses;
        Professor = professor;
        Time = time;
    }

    public static void addcourse(List<Course> Courses)
    {
        {
            Console.WriteLine("what is the name of the course you want to create?");
            string courses = Console.ReadLine();
            Console.WriteLine("what professor is going to teach the course?");
            string professor = Console.ReadLine();
            Console.WriteLine("how long is the course going to be?");
            string time = Console.ReadLine();

            Courses.Add(new Course(courses, professor, time));
            Courses.Add(new Course("Math", "Max", "0"));
        }
    }

    public void ShowCourse(List<Course> courses)
    {
        Console.WriteLine("courses avalible are:");
        foreach (Course c in courses)
        {
            Console.WriteLine($"kurs: {c.Courses}, lärare: {c.Professor}, time: {c.Time}years");
        }
    }



}

/*        Console.WriteLine("____add a course___");
        Console.WriteLine("enter 'create' to make a course");
        string input = Console.ReadLine();
        if (input == "create");
        */