namespace AuthenticationPrototype.Models.Authentication;

public abstract class Account
{
    private string _username;
    private string _password;

    public Account(string user, string pass)
    { 
        this._username = user;
        this._password = pass;
    }
    public abstract bool Login(string user, string pass);
}