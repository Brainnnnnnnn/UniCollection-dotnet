namespace UniCollection.Dtos;

public class ResourceDto
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Url { get; set; }

    public string Type { get; set; }  // 建议用 string 或枚举映射

    public int? CategoryId { get; set; }

    public string RemarkMd { get; set; }

}