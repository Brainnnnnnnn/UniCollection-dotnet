using SqlSugar;
using UniCollection.Models;

namespace UniCollection.Repositories;

public class CateoryRepository(ISqlSugarClient _db) : BaseRepository<Category>(_db)
{
    
}