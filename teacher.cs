namespace App;

class Teacher : IUser
{
    public string Username;
    string _password;

    public Teacher(string username, string password)
    {
        Username = username;
        _password = password;
    }

    public bool TryLogin(string username, string password)
    {
        return username == Username && password == _password;
    }
}