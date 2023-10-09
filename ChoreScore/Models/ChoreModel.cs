namespace ChoreScore.Models;

public class Chore
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Worker { get; set; }
    public int Minutes { get; set; }
    public bool HiPriority { get; private set; }

    public float MinutesAddedSetUp
    {
        get { return Minutes * 2; }
    }
    public Chore(int id, string name, string worker, int minutes, bool hipriority)
    {
        Id = id;
        Name = name;
        Worker = worker;
        Minutes = minutes;
        HiPriority = hipriority;
    }
}