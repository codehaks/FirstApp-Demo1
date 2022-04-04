namespace FirstApp.Common;

public class ApplicationState
{
    private readonly Dictionary<string, string> _state;

    public ApplicationState()
    {
        _state = new Dictionary<string, string>();
    }

    public void Set(string key,string value)
    {
        _state[key] = value;
    }

    public string Get(string key)
    {
        return _state[key];
    }
}
