namespace App;

public class Messages
{
    public static void StudentMenu()
    {
        Console.WriteLine("===== Student Menu =====");
        Console.WriteLine("1. View my courses");
        Console.WriteLine("2. Check schedule");
        Console.WriteLine("3. Submit assignment");
        Console.WriteLine("4. View grades/results");
        Console.WriteLine("5. Log out");
        Console.Write("Choose an option: ");
    }

    public static void TeacherMenu()
    {
        Console.WriteLine("===== Teacher Menu =====");
        Console.WriteLine("1. View my courses");
        Console.WriteLine("2. Add or edit assignments");
        Console.WriteLine("3. Grade student submissions");
        Console.WriteLine("4. Check schedule");
        Console.WriteLine("5. Log out");
        Console.Write("Choose an option: ");
    }

    public static void AdminMenu()
    {
        Console.WriteLine("===== Admin Menu =====");
        Console.WriteLine("1. Manage users (students/teachers)");
        Console.WriteLine("2. Create new course");
        Console.WriteLine("3. Log out");
        Console.Write("Choose an option: ");
    }

    public static void ManageUsersMenu()
    {
        Console.WriteLine("===== Manage Users =====");
        Console.WriteLine("Write the word in (parentheses)!!");
        Console.WriteLine("(Add) new user");
        Console.WriteLine("(Edit) existing user");
        Console.WriteLine("(Remove) user");
        Console.WriteLine("(View )all users");
        Console.WriteLine("(Back) to Admin Menu");
        Console.Write("Choose an option: ");
    }
    public static void EnterToContinue()
    {
        Console.WriteLine("Enter to continue...");
        Console.ReadLine();
    }
}