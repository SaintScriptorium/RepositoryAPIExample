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
    public IEnumerable<Persons> GetAll()
    {
        return service.GetAll();
    }

    [HttpGet("/ByID")]
    public Persons GetById(int Id)
    {
        return service.GetById(Id);
    }
    [HttpPost]
    public string Post(Persons person)
    {
        return service.Post(person);
    }

    [HttpPut]
    public string Put(Persons person)
    {
        return service.Update(person);
    }

    [HttpDelete]
    public string Delete(int Id)
    {
        return service.Delete(Id);
    }
}