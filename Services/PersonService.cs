using RepositoryAPIs.Interfaces;
using RepositoryAPIs.Models;
using RepositoryAPIs.Context;
namespace RepositoryAPIs.Services;


public class PersonService : IPersons
{
    private readonly DatabasesContexts _context;

    public PersonService(DatabasesContexts _context)
    {
        this._context = _context;
    }
    public IEnumerable<Persons> GetAll()
    {
             
        return _context.Personas.ToList();
    }


    public Persons GetById(int Id)
    {
        return null;
    }

    public string Post(Persons person)
    {
        _context.Personas.Add(person);
        _context.SaveChanges();
        return "Registry saved";
    }

    public string Update(Persons person)
    {
        return null;
    }

    public string Delete(int id)
    {
        return null;
    }
}