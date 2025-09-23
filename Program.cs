using App;

List<IUser> users = new List<IUser>();
List<Course> Courses = new List<Course>();
users.Add(new Student("teststudent", "mail", "pass"));
users.Add(new Teacher("robin", "password"));
users.Add(new Admin("testadmin", "pass"));

IUser? active_user = null;

bool running = true;

while (running)
{
    Console.Clear();

    if (active_user == null)
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Clear();

        Console.Write("Password: ");
        string password = Console.ReadLine();
        Console.Clear();

        foreach (IUser user in users)
        {
            if (user.TryLogin(username, password))
            {
                active_user = user;
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("--- School System ---");

        if (active_user is Teacher teacher)
        {
            Console.WriteLine("Welcome Teacher" + teacher.Username);
        }
        if (active_user is Student student)
        {
            Console.WriteLine("Welcome Student " + student.Name);
            Console.WriteLine();
        }
        if (active_user is Admin admin)
        {
            Console.WriteLine("Welcome Admin " + admin.Name);
            Console.WriteLine("enter account to make a new account");
            Console.WriteLine("enter course to create a course");
            Console.WriteLine("logout");

            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "account":
                    admin.CreateAccount(users);
                    break;

                case "course":
                    Course.addcourse(Courses);
                    break;

                case "logout":
                    active_user = null;
                    break;
            }
        }
    }
}

// Recreate Learnpoint in the Terminal
// Logga in, Logga ut
// Students, Teachers, Admin
// Admin can create new accounts
// Admin can create courses

// show courses

// Create schedules with events
// Teachers can grade exams
// Students can upload files to exams
// Upload documents

// ...
