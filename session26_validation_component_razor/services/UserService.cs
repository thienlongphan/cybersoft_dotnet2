public class UserService 
{
    public event Action? OnChanged;
    private string _currentUser;

    public string CurrentUser 
    {
        get 
        {
            return _currentUser;
        }
    }

    public void Login(string userName) 
    {
        _currentUser = userName;
        // NotifyStateChange();
    }

    private void NotifyStateChange() 
    {
        if(OnChanged != null) 
        {
            OnChanged.Invoke();
        }
    }

    public bool IsAuthenticated() 
    {
        return !string.IsNullOrEmpty(CurrentUser);
    }

    public void Logout() 
    {
        _currentUser = string.Empty;
        // NotifyStateChange();
    }
}