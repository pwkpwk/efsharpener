namespace c_lib;

public class Weather
{
    public Weather(bool isNice)
    {
        IsNice = isNice;
    }
    
    public bool IsNice { get; private set; }

    public bool Change(bool nice)
    {
        bool changed = IsNice != nice;

        if (changed)
        {
            IsNice = nice;
        }

        return changed;
    }
}