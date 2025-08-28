using SqlSugar;
using UniCollection.Models;

namespace UniCollection.Repositories;

public class BaseRepository<T>(ISqlSugarClient _db) where T : class, IEntity, new()
{

    public List<T> GetAll()
    {
        return _db.Queryable<T>().ToList();
    }
    
    public T GetById(int id)
    {
        return _db.Queryable<T>().First(it => it.Id == id);
    }
    
    public void Add(T entity)
    {
        _db.Insertable(entity).ExecuteReturnIdentity();
    }

    public void Update(T entity)
    {
        _db.Updateable(entity).ExecuteCommand();
    }

    public int DeleteById(int id)
    {
        return _db.Deleteable<T>(new T() { Id = id }).ExecuteCommand();
    }
    
    
    
}