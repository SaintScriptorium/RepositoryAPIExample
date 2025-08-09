using RepositoryAPIs.Models;
namespace RepositoryAPIs.Repositories.InterfacesRepositories;

public interface IPersonRepository
{
    Task <IEnumerable<Persons>> GetAll();
    Persons GetById(int id);
    Persons Post(Persons person);
    bool Update(Persons person);
    bool Delete(int id);
}