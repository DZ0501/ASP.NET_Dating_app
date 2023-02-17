using Foundation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Foundation.Models;

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
        
        return id is null ? null : _context.Person.Include("Interest_first_model")
            .Include("Interest_second_model")
            .Include("Interest_third_model")
            .Include("Relationship_status_model")
            .Include("Business_model")
            .Include("Zodiac_sign_model")
            .Include("Education_model")
            .Include("Pet_model")
            .Include("Religion_model")
            .Include("Alcohol_model")
            .Include("Smoking_model")
            .FirstOrDefault(x => x.Person_modelId == id);
    }

    public ICollection<Person_model> FindAllByInterest(int? id)
    {
        var list = _context.Person.Include("Interest_first_model")
            .Include("Interest_second_model")
            .Include("Interest_third_model")
            .Include("Relationship_status_model")
            .Include("Business_model")
            .Include("Zodiac_sign_model")
            .Include("Education_model")
            .Include("Pet_model")
            .Include("Religion_model")
            .Include("Alcohol_model")
            .Include("Smoking_model")
            .Where(x => x.Interest_first_model.Interest_modelId == id)

            .ToList();

        return list;
    }

    public ICollection<Person_model> FindAll()
    {
        var list = _context.Person.Include("Interest_first_model")
            .Include("Interest_second_model")
            .Include("Interest_third_model")
            .Include("Relationship_status_model")
            .Include("Business_model")
            .Include("Zodiac_sign_model")
            .Include("Education_model")
            .Include("Pet_model")
            .Include("Religion_model")
            .Include("Alcohol_model")
            .Include("Smoking_model")
            .ToList();

        return list;    
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}