namespace AuthenticationPrototype.Models.Authentication;

public class FormValidation : Account
{
    public bool ValidateUsername(string username)
    {
        if (username == "user")
        {
            return true;
        }
        return false;
    }
    
    public bool ValidatePassword(string password)
    {
        if (password == "user")
        {
            return true;
        }
        return false;
    }
    public FormValidation(string user, string pass) : base(user, pass)
    {
        ValidateUsername("user");
        ValidatePassword("user");
    }

    public override bool Login(string user, string pass)
    {
        return ValidateUsername(user) && ValidatePassword(pass);
    }
}