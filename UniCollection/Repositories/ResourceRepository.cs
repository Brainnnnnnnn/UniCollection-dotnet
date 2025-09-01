using SqlSugar;
using UniCollection.Models;

namespace UniCollection.Repositories;

public class ResourceRepository(ISqlSugarClient _db) : BaseRepository<Resource>(_db)
{
    
}