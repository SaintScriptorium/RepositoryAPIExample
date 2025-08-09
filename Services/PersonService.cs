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
    public Task<IEnumerable<Persons>> GetAll()
    {
        return  repository.GetAll();
    }


    public Persons GetById(int Id)
    {
        return repository.GetById(Id);
    }

    public Persons Post(Persons person)
    {
        return repository.Post(person);
    }

    public bool Update(Persons person)
    {
        return repository.Update(person);
        
    }

    public bool Delete(int Id)
    {
        return repository.Delete(Id);
    }
}