using UniCollection.Dtos;
using UniCollection.Models;
using UniCollection.Repositories;

namespace UniCollection.Services;

public class ResourceService(ResourceRepository _resourceRepository)
{
    public List<Resource> GetResources()
    {
        return _resourceRepository.GetAll();
    }


    public Resource GetResourceById(int id)
    {
        return _resourceRepository.GetById(id);
    }

    public int AddResource(ResourceDto categoryDto)
    {
        var resource = new Resource();
        resource.Title = categoryDto.Title;
        resource.Url = categoryDto.Url;
        resource.Type = categoryDto.Type;
        resource.CategoryId = categoryDto.CategoryId;
        resource.RemarkMd = categoryDto.RemarkMd;
        resource.CreateTime = DateTime.Now;
        _resourceRepository.Add(resource);
        return resource.Id;
    }

    public int DeleteResourceById(int id)
    {
        return _resourceRepository.DeleteById(id);
    }
}