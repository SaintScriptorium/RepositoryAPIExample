using RepositoryAPIs.Models;

namespace RepositoryAPIs.Interfaces;

public interface IPersons
{
    IEnumerable<Persons> GetAll();
    Persons GetById(int id);
    string Post(Persons person);
    string Update(Persons person);
    string Delete(int id);
}