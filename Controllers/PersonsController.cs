using Microsoft.AspNetCore.Mvc;
using RepositoryAPIs.Models;
using RepositoryAPIs.Interfaces;

namespace RepositoryAPIs.Controllers;

[ApiController]
[Route("/[controller]")]

public class PersonsController : ControllerBase
{
    private readonly IPersons service;

    public PersonsController(IPersons service)
    {
        this.service = service;
    }
    [HttpGet]
    public IEnumerable<Persons> GetAll()
    {
        return service.GetAll();
    }

    [HttpPost]
    public string Post(Persons person)
    {
        return service.Post(person);
    }
}