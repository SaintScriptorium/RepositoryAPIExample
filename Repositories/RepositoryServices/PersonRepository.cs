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
    public async Task<IEnumerable<Persons>> GetAll()
    {
        return await _context.Personas.ToListAsync();
    }
    
    public Persons GetById(int Id)
    {
        var person = _context.Personas.Find(Id);
        return person;
    }

    public Persons Post(Persons person)
    {
        _context.Personas.Add(person);
        _context.SaveChanges();
        return person;
    }

    public bool Update(Persons person)
    {
        _context.Entry(person).State = EntityState.Modified;
        try
        {
            _context.SaveChanges();
            return true;
        }catch(DbUpdateConcurrencyException){
        return false;
        }
    }

    public bool Delete(int Id)
    {
        var person = _context.Personas.Find(Id);
        if(person == null){ 
            return false;
        }
        else
        {
            _context.Personas.Remove(person);
            _context.SaveChanges();
            return true;
        }
    }
}