using RepositoryAPIs.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoryAPIs.Context;

public class DatabasesContexts : DbContext
{
    public DatabasesContexts(DbContextOptions<DatabasesContexts> db):base(db)
    {
        
    }

    public DbSet<Persons> Personas { get; set; }
}