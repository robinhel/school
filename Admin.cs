using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace App;

class Admin : IUser
{
    public string Name;
    public string _password;


    public Admin(string name, string password)
    {
        Name = name;
        _password = password;

    }

    public bool TryLogin(string name, string password)
    {
        return name == Name && password == _password;
    }

    public void CreateAccount(List<IUser> users)
    {
        bool running = true;
        while (running)
        {

            Console.WriteLine("pick role: student, teacher, admin.");
            string input = Console.ReadLine();

            switch (input)
            {

                case "student":

                    Console.WriteLine("new Username for student account:");
                    string s_username = Console.ReadLine();
                    Console.WriteLine("new Username for student account:");
                    string s_mail = Console.ReadLine();
                    Console.WriteLine("new mail for student account:");
                    string s_password = Console.ReadLine();
                    Console.WriteLine($"new Student account with u: {s_username}, m: {s_mail} and p: {s_password} has been created.");
                    Console.WriteLine("enter quit to exit");

                    users.Add(new Student(s_username, s_mail, s_password));
                    break;

                case "teacher":
                    Console.WriteLine("new Username for teacher account:");
                    string t_username = Console.ReadLine();
                    Console.WriteLine("new Password for teacher account:");
                    string t_password = Console.ReadLine();
                    Console.WriteLine($"new teacher account with u: {t_username} and p: {t_password} has been created.");
                    Console.WriteLine("enter quit to exit");
                    users.Add(new Teacher(t_username, t_password));
                    break;

                case "admin":
                    Console.WriteLine("new Username for admin account:");
                    string a_username = Console.ReadLine();
                    Console.WriteLine("new Password for admin account:");
                    string a_password = Console.ReadLine();
                    Console.WriteLine($"new admin account with u: {a_username} and p: {a_password} has been created.");
                    Console.WriteLine("enter quit to exit");
                    users.Add(new Admin(a_username, a_password));
                    break;

                case "quit":
                    running = false;
                    break;





            }
        
        }
        
    }
}


