using System.Collections;
using App;

List<IUser> users = new List<IUser>();
List<Course> Courses = new List<Course>();
Courses.Add(new Course("math", "Calle", "long"));
users.Add(new Student("s", "s", "s"));
users.Add(new Teacher("t", "t"));
users.Add(new Admin("a", "a"));

IUser? active_user = null;

bool running = true;



while (running)
{
    Console.Clear();

    if (active_user == null) //-----------------------------------LOGIN---------------------------------------------
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

        if (active_user is Teacher teacher) //-----------------------TEACHER-----------------------------------------
        {
            teacher.Show();
            Messages.TeacherMenu();
            string t_input = Console.ReadLine();
            switch (t_input)
            {
                case "1":
                    //view
                    break;
                case "2":
                    //Add 
                    break;
                case "3":
                    //Grade (wait)
                    break;
                case "4":
                    //schedule
                    break;
                case "5":
                    //Logout
                    active_user = null;
                    break;
            }
        }
        if (active_user is Student student) //--------------------------STUDENT----------------------------------------
        {
            student.Show();
            Messages.StudentMenu();
            string s_input = Console.ReadLine();
            switch (s_input)
            {
                case "1":
                    Course.ShowCourse(Courses);
                    Messages.EnterToContinue();
                    //view courses
                    break;
                case "2":
                    //Check schedule
                    break;
                case "3":
                    //Submit assignment

                    break;
                case "4":
                    //Check Grades (wait)
                    break;
                case "5":
                    //logout
                    active_user = null;
                    break;
            }


        }
        if (active_user is Admin admin) //---------------------------------ADMIN--------------------------------------
        {
            admin.Show();
            Messages.AdminMenu();

            string a_input = Console.ReadLine().ToLower();
            switch (a_input)
            {

                case "1":
                    //Manage users (add or remove)
                    Messages.ManageUsersMenu();
                    switch (Console.ReadLine().ToLower())
                    {
                        case "add":
                            admin.CreateAccount(users);
                            break;
                        case "remove":
                            admin.RemoveUser(users);
                            Console.ReadLine();
                            break;
                    }
                    break;
                case "2":
                    //Create a course
                    Course.addcourse(Courses, users);
                    break;

                case "3":
                    //Logout
                    active_user = null;
                    break;

                case null:
                    Console.WriteLine("please enter a valid number!");
                    break;
            }
            //----------------------------------------------------------------------------------------------------------
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
