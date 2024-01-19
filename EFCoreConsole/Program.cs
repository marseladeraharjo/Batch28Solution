using EFCoreLibrary;
using EFCoreLibrary.AdventureContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static IConfigurationRoot _configuration;
    private static DbContextOptionsBuilder<AdventureWorks2019Context> _optionsBuilder;

    private static void Main(string[] args)
    {
        BuildConfiguration();
        BuildOptions();
        ListPerson();
        CrudPerson();
    }

    private static void BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        _configuration = builder.Build();

        Console.WriteLine(_configuration.GetConnectionString("AdventureWorkDS"));
    }

    static void BuildOptions()
    {
        _optionsBuilder = new DbContextOptionsBuilder<AdventureWorks2019Context>();
        _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AdventureWorkDS"));
    }

    static void ListPerson()
    {
        using (var db = new AdventureWorks2019Context(_optionsBuilder.Options))
        {
            var persons = db.People.OrderByDescending(x => x.FirstName).Take(20).ToList();
            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
            }
        }
    }

    static void CrudPerson()
    {
        using (var db = new AdventureWorks2019Context(_optionsBuilder.Options))
        {
            // insert data into BusinessEntity Table
            BusinessEntity businessEntity = new BusinessEntity();
            db.Add(businessEntity);
            //db.SaveChanges();
            Console.WriteLine($"{businessEntity.BusinessEntityId}");

            var person = new Person()
            {
                FirstName = "Kang",
                LastName = "Dian",
                PersonType = "EM",
                BusinessEntity = businessEntity
            };

            db.Add(person);
            db.SaveChanges();
            Console.WriteLine($"New Person : {person.BusinessEntityId}- {person.FirstName} {person.LastName}");

            // find person
            var foundPerson = db.People.Find(businessEntity.BusinessEntityId);
            Console.WriteLine($"Found Person : {person.BusinessEntityId}- {person.FirstName} {person.LastName}");

            // update person
            person.FirstName = "Rini";
            person.LastName = "Marlina";
            db.Update(person);
            Console.WriteLine($"Update Person : {person.BusinessEntityId}- {person.FirstName} {person.LastName}");
            db.SaveChanges();

            // delete person
            db.People.Remove(foundPerson);
            Console.WriteLine($"Remove Person : {person.BusinessEntityId}- {person.FirstName} {person.LastName}");
            db.SaveChanges();
        }
    }
}