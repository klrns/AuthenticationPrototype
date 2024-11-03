using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using AuthenticationPrototype.Models.Authentication;

namespace AuthenticationPrototype.ViewModels;

public partial class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public string _textBlockResult;
    public string _textBoxUser;
    public string _textBoxPass;

    public string TextBlockResult
    {
        get
        {
            return _textBlockResult;
        }
        set
        {
            _textBlockResult = value;
            OnPropertyChanged();
        }
    }

    public string TextBoxUser
    {
        get
        {
            return _textBoxUser;
        }
        set
        {
            _textBoxUser = value;
            OnPropertyChanged();
        }
    }
    public string TextBoxPass
    {
        get
        {
            return _textBoxPass;
        }
        set
        {
            _textBoxPass = value;
            OnPropertyChanged();
        }
    }
    public void LoginButtonClicked()
    {
        FormValidation valid = new FormValidation(TextBoxUser, TextBoxPass);
        if (valid.ValidateUsername(TextBoxUser) && valid.ValidatePassword(TextBoxPass))
        {
            TextBlockResult = "You're logged in!";
        }
        else
        {
            TextBlockResult = "Wrong username or password!";
        }
    }
}