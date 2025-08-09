using Microsoft.AspNetCore.Mvc;
using RepositoryAPIs.Models;
using RepositoryAPIs.Services;

namespace RepositoryAPIs.Controllers;

[ApiController]
[Route("/[controller]")]

public class PersonsController : ControllerBase
{
    private readonly PersonService service;

    public PersonsController(PersonService service)
    {
        this.service = service;
    }
    [HttpGet]
    public async Task<IEnumerable<Persons>> GetAll()
    {
        return await service.GetAll();
    }

    [HttpGet("/Getby{id}")]
    public Persons GetById(int id)
    {
        return service.GetById(id);
    }
    [HttpPost]
    public Persons Post(Persons person)
    {
        return service.Post(person);
    }

    [HttpPut]
    public bool Put(Persons person)
    {
        return service.Update(person);
    }

    [HttpDelete]
    public bool Delete(int Id)
    {
        return service.Delete(Id);
    }
}