namespace App;

class Student : IUser
{
    public string Name;
    public string Email;
    string _password;

    public Student(string name, string email, string password)
    {
        Name = name;
        Email = email;
        _password = password;
    }

    public bool TryLogin(string username, string password)
    {
        return username == Email && password == _password;
    }
        public void Show()
    {
        Console.WriteLine($"Logged in: {Name}");
    }
        
}