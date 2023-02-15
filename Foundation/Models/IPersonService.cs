namespace Foundation.Models;

public interface IPersonService
{
    public int Save(Person_model person);

    public bool Delete(int? id);

    public bool Update(Person_model person);

    public Person_model? FindBy(int? id);

    public ICollection<Person_model> FindAll();


    /*

    public ICollection<Person_model> FindBySurname(Person_model person);

    public ICollection<Person_model> FindPage(int page, int size);
    */

}
