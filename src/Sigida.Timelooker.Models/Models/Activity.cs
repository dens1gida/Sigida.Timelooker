namespace Sigida.Timelooker.Models.Models;

public class Activity
{
    public string Name { get; init; }
    public DateTime Start { get; init; }
    public DateTime End { get; init; }
    public TimeSpan TotalTime => End - Start;

}
