using Microsoft.EntityFrameworkCore;
using Models;

namespace Database
{
  public class DatabaseContext : DbContext
  {
    public virtual DbSet<Client>? Clients { get; set; }

    public DatabaseContext() { }

    public DatabaseContext(DbContextOptions options): base(options)
    {
      Clients.Add(new Client {
        Id = 1,
        FirstName = "Client 1",
        LastName = "Bonjour",
        Birthdate = new System.DateTime(2000, 1, 1)
      });
    }
  }
}