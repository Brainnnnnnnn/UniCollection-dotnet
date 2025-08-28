using SqlSugar;

namespace UniCollection.Models;

[SugarTable("Category")]
public class Category : IEntity
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; }
    
    [SugarColumn(IsNullable = false, Length = 100)]
    public string Name { get; set; }
    
    [SugarColumn(IsNullable = true)]
    public int? ParentId { get; set; }

    // 可选：导航属性（不会建表，只是便于查询时映射）
    [SugarColumn(IsIgnore = true)]
    public List<Resource> Resources { get; set; }
}