namespace App;

public interface IUser
{
    public bool TryLogin(string username, string password);

    public void Show();
}