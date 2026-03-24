using RestWithAspNet10.Model;

namespace RestWithAspNet10.Services
{
    public interface IPersonServices
    {
        Person Create(Person person);
        Person FindById(int id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
