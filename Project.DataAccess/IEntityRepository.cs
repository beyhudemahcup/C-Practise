using Project.Entities;

namespace Project.DataAccess;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    //adding generic constraint is important to code easily. That is why we should use
    //(where T : class,IEntity,new()) -> it is the way how we can use
    //class means reference type
    List<T> GetAll();
    T GetById(int Id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
