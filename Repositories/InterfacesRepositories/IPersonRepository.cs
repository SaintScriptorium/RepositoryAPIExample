using RepositoryAPIs.Models;
namespace RepositoryAPIs.Repositories.InterfacesRepositories;

public interface IPersonRepository
{
    IEnumerable<Persons> GetAll();
    Persons GetById(int id);
    string Post(Persons person);
    string Update(Persons person);
    string Delete(int id);
}