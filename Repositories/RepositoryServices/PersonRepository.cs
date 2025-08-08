using RepositoryAPIs.Context;
using RepositoryAPIs.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryAPIs.Repositories.InterfacesRepositories;
namespace RepositoryAPIs.Repositories.RepositoryServices;

public class PersonRepository : IPersonRepository
{
    private readonly DatabasesContexts _context;

    public PersonRepository(DatabasesContexts _context)
    {
        this._context = _context;
    }
    public IEnumerable<Persons> GetAll()
    {
             
        return _context.Personas.ToList();
    }


    public Persons GetById(int Id)
    {
        var person = _context.Personas.Find(Id);
        return person;
    }

    public string Post(Persons person)
    {
        _context.Personas.Add(person);
        _context.SaveChanges();
        return "Registry saved";
    }

    public string Update(Persons person)
    {
        _context.Entry(person).State = EntityState.Modified;
        _context.SaveChanges();
        return "Registry modified";
    }

    public string Delete(int Id)
    {
        var person = _context.Personas.Find(Id);
        _context.Personas.Remove(person);
        _context.SaveChanges();
        return "Registry deleted";
    }
}