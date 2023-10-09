

namespace ChoreScore.Services;

public class ChoresService
{

    private readonly ChoresRepository _repository;

    public ChoresService(ChoresRepository repository)
    {
        _repository = repository;
    }

    internal Chore CreateChore(Chore ChoreData)
    {
        Chore chore = _repository.CreateChore(ChoreData);
        return chore;
    }
    internal List<Chore> GetChores()
    {
        List<Chore> chores = _repository.GetChores();
        return chores;
    }


    internal Chore GetChoreById(int choreId)
    {
        Chore chore = _repository.GetChoreById(choreId);
        if (chore == null) throw new Exception($"not a chore with this id{choreId}");
        return chore;
    }


    internal string RemoveChore(int choreId)
    {
        Chore chore = this.GetChoreById(choreId);
        _repository.RemoveChore(choreId);
        return $"{chore.Name} has been removed";
    }
}