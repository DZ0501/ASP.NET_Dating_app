using Foundation.Models;
using Microsoft.EntityFrameworkCore;

namespace lab_8.Models;

public class PersonService_model: IPersonService
{
    private readonly FoundationContext _context;

    public PersonService_model(FoundationContext context)
    {
        _context = context;
    }

    public int Save(Person_model person)
    {
        try
        {
            var entityEntry = _context.Person.Add(person);
            _context.SaveChanges();
            return entityEntry.Entity.Person_modelId;
        }
        catch
        {
            return -1;
        }
    }
    public bool Delete(int? id)
    {
        if (id is null)
        {
            return false;
        }
        
        var find = _context.Person.Find(id);
        if (find is not null)
        {
            _context.Person.Remove(find);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Update(Person_model person)
    {
        try
        {
            var find = _context.Person.Find(person.Person_modelId);
            if (find is not null)
            {
                find.LastName = person.LastName;
                //find.ReleaseDate = book.ReleaseDate;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        catch(DbUpdateConcurrencyException)
        {
            return false;
        }
    }

    public Person_model? FindBy(int? id)
    {
        return id is null ? null : _context.Person.Find(id);
    }

    public ICollection<Person_model> FindAll()
    {
        return _context.Person.ToList();
    }

    public ICollection<Person_model> FindByAuthor(Person_model person)
    {   
        throw new NotImplementedException();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}