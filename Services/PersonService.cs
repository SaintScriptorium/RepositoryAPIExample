using RepositoryAPIs.Repositories.InterfacesRepositories;
using RepositoryAPIs.Models;
namespace RepositoryAPIs.Services;
public class PersonService 
{
    private readonly IPersonRepository repository;

    public PersonService(IPersonRepository repo)
    {
        repository = repo;
    }
    public IEnumerable<Persons> GetAll()
    {
        return repository.GetAll();
    }


    public Persons GetById(int Id)
    {
        return repository.GetById(Id);
    }

    public string Post(Persons person)
    {
        return repository.Post(person);
    }

    public string Update(Persons person)
    {
        return repository.Update(person);
        
    }

    public string Delete(int Id)
    {
        return repository.Delete(Id);
    }
}