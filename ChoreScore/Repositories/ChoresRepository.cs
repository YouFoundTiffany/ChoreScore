

namespace ChoreScore.Repositories;

public class ChoresRepository
{

    private List<Chore> _FakeChoreDb;

    public ChoresRepository()
    {
        _FakeChoreDb = new List<Chore>();
        _FakeChoreDb.Add(new Chore(1, "PWash12x12DriveWay", "Erica", 60, false));
        _FakeChoreDb.Add(new Chore(1, "PWash24x12DriveWay", "Jessica", 90, false));
        _FakeChoreDb.Add(new Chore(2, "PWash12x12Wall", "Danielle", 60, true));
        _FakeChoreDb.Add(new Chore(3, "PWash22x12Wall", "Angela", 90, true));
        _FakeChoreDb.Add(new Chore(4, "MowAcreHalf", "Josie", 90, true));
        _FakeChoreDb.Add(new Chore(5, "MowAcreOne", "Kimberly", 90, true));
        _FakeChoreDb.Add(new Chore(6, "MowAcreTwo", "Tanna", 180, true));
        _FakeChoreDb.Add(new Chore(7, "MowAcreThree", "Kennedy", 270, true));
        _FakeChoreDb.Add(new Chore(8, "MowAcreFour", "Kennedy", 360, true));
    }


    internal Chore CreateChore(Chore choreData)
    {
        int choreId = _FakeChoreDb[_FakeChoreDb.Count - 1].Id;
        choreData.Id = choreId + 1;
        _FakeChoreDb.Add(choreData);
        return choreData;
    }

    internal List<Chore> GetChores()
    {
        return _FakeChoreDb;
    }

    internal Chore GetChoreById(int choreId)
    {
        Chore chore = _FakeChoreDb.Find(chore => chore.Id == choreId);
        return chore;
    }

    internal void RemoveChore(int choreId)
    {
        Chore chore = _FakeChoreDb.Find(chore => chore.Id == choreId);
        _FakeChoreDb.Remove(chore);
    }



}

