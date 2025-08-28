using SqlSugar;

namespace UniCollection.Models;

[SugarTable("Resource")]
public class Resource : IEntity
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; }

    [SugarColumn(Length = 255, IsNullable = false)]
    public string Title { get; set; }

    [SugarColumn(ColumnDataType = "TEXT", IsNullable = false)]
    public string Url { get; set; }

    [SugarColumn(Length = 50, IsNullable = false)]
    public string Type { get; set; }  // 建议用 string 或枚举映射

    public int? CategoryId { get; set; }

    [SugarColumn(ColumnDataType = "TEXT", IsNullable = true)]
    public string RemarkMd { get; set; }

    [SugarColumn(IsNullable = false)]
    public DateTime CreateTime { get; set; } = DateTime.Now;

    // 导航属性
    [SugarColumn(IsIgnore = true)]
    public Category Category { get; set; }
}